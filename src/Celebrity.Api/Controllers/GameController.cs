using Celebrity.GamingContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Celebrity.Api
{
    [ApiController]
    [Route(Celebrity.Shared.GameEndpoints.Base)]
    public class GameController : ControllerBase
    {
        private readonly GameFinder finder;

        [HttpGet, Route("{gameId}")]
        public async Task<IActionResult> Get(Guid gameId)
        {
            var game = await finder.Find(gameId);
            return Ok(game);
        }
    }
}
