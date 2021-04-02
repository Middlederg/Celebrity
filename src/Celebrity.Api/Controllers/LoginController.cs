using Celebrity.Data;
using Celebrity.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Api
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly TokenGenerator tokenGenerator;
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;

        public LoginController(TokenGenerator tokenGenerator,
                               SignInManager<User> signInManager, 
                               UserManager<User> userManager)
        {
            this.tokenGenerator = tokenGenerator;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel login)
        {
            var result = await signInManager.PasswordSignInAsync(login.Email, login.Password, false, true);

            if (!result.Succeeded)
            {
                return BadRequest(new LoginResult { Successful = false, Error = "Username and password are invalid." });
            }

            var user = await userManager.FindByEmailAsync(login.Email);
            var roles = await userManager.GetRolesAsync(user);

            string token = tokenGenerator.GenerateToken(user, roles.ToArray());

            var loginResult = new LoginResult { Successful = true, Token = token };

            return Ok(loginResult);
        }
    }
}
