using Celebrity.Domain;
using Celebrity.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Celebrity.Api
{
    [ApiController]
    [Route(CategoryEndpoints.Base)]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryFinder finder;
        private readonly CategoryLister lister;

        [HttpGet, Route("{categoryId}")]
        public async Task<ActionResult<Shared.Category>> Get(int categoryId)
        {
            var categoryValue = (CategoryValue)categoryId;
            var category = await finder.Find(categoryValue);
            var result = category.ToDto();
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shared.Category>>> GetAll()
        {
            var categories = await lister.ToList();
            var result = categories.Select(x => x.ToDto());
            return Ok(result);
        }
    }
}
