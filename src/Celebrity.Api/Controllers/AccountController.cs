using Microsoft.AspNetCore.Mvc;
using System;

namespace Celebrity.Api
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpGet]
        public IActionResult Login([FromBody]string username)
        {
            if (!username.Equals("abcd"))
            {
                throw new UnauthorizedAccessException();
            }
            return Ok();
        }
    }
}
