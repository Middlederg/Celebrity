using Celebrity.Data;
using Celebrity.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Celebrity.Api
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly IEmailSender emailSender;

        public AccountController(UserManager<User> userManager, IEmailSender emailSender)
        {
            this.userManager = userManager;
            this.emailSender = emailSender;
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

            var code = await userManager.GenerateEmailConfirmationTokenAsync(newUser);
            var callbackUrl = Url.Action("ConfirmEmail", "Account",
                values: new { userId = user.Id, code },
                protocol: Request.Scheme);

            string encodedUrl = HtmlEncoder.Default.Encode(callbackUrl);
            await emailSender.SendEmailAsync(user.Email, EmailSubjects.ConfirmEmailSubject,
                $"Please, <a href='{encodedUrl}'>confirm</a> your email to be able to login.");

            return new RegisterResult { Email = model.Email, UserId = Guid.Parse(newUser.Id) };
        }

        [HttpPost, Route(UserEndpoints.ConfirmEmail)]
        public async Task<IActionResult> ConfirmEmail(ConfirmEmailModel model)
        {
            if (!model.UserId.HasValue ||  string.IsNullOrWhiteSpace(model.Code))
            {
                throw new DomainException("Incorrect user or code");
            }

            var user = await userManager.FindByIdAsync(model.UserId.ToString());
            if (user is null)
            {
                throw new NotFoundException(model.UserId.Value);
            }

            var result = await userManager.ConfirmEmailAsync(user, model.Code);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Error confirming email for user with Id '{model.UserId}':");
            }
            return Ok();
        }

    }
}
