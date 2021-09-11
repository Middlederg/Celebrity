using Celebrity.Data;
using Celebrity.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Api
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> userManager;

        public AccountController(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost, Route(UserEndpoints.Register)]
        public async Task<ActionResult<RegisterResult>> Post(RegisterModel model)
        {
            var user = await userManager.FindByNameAsync(model.Email);
            if (user != null)
            {
                throw new DomainException($"User {model.Email} is already taken");
            }

            var newUser = new User { UserName = model.Email, Email = model.Email };
            var result = await userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
            {
                throw new DomainException(string.Join(", ", result.Errors.Select(x => x.Description)));
            }


            var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Action("ConfirmEmail", "Account",
                values: new { userId = user.Id, code },
                protocol: Request.Scheme);

            //string encodedUrl = HttpUtility.UrlEncode(code);
            string encodedUrl = HtmlEncoder.Default.Encode(callbackUrl);
            await emailSender.SendEmailAsync(user.Email, EmailSender.ConfirmEmailSubject,
                $"Por favor, confirme su correo electrónico <a href='{encodedUrl}'>aquí</a>.");

            return new RegisterResult { Email = model.Email };
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                throw new DomainException("Incorrect code");
            }

            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return new NotFoundException(userId);
            }

            var result = await userManager.ConfirmEmailAsync(user, code);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Error confirming email for user with ID '{userId}':");
            }

            await emailSender.NotifyToSuscriber($"Se ha registrado correctamente el usuario {user.Email}. " +
                $"Establezca los permisos en las aplicaciones que sean necesarios");

            return View();
        }

    }
}
