using Celebrity.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Celebrity.Api
{
    [ApiController]
    [Route(Shared.GameEndpoints.Base)]
    public class GameController : ControllerBase
    {
        private readonly GameFinder finder;
        private readonly GameCreator creator;
        private readonly GameEraser eraser;

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var gameId = new GameId(id); 
            var game = await finder.Find(gameId);
            var result = game.ToDto();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Shared.Game>> Create(Shared.CreateGameCommand command)
        {
            var game = await creator.Create(command);
            var result = game.ToDto();
            return CreatedAtAction(result, new { game.id }, result);
        }

        [HttpDelete, Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var gameId = new GameId(id);
            await eraser.Delete(gameId);
            return NoContent();
        }
    }
}
