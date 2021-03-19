using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Celebrity.Api
{
    [ApiController]
    [Route(Shared.GameConceptEndpoints.Base)]
    public class DeckController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Shared.GuessConceptResponse>> Guess(Shared.GuessConceptCommand command)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Shared.GuessConceptResponse>> NextRound(Shared.NextRoundCommand command)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> TimesUp(Shared.TimesUpCommand command)
        {
            return Ok();
        }
    }
}
