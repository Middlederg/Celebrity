using Celebrity.Domain;
using Celebrity.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

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

    [ApiController]
    [Route(SubcategoryEndpoints.Base)]
    public class SubcategoryController : ControllerBase
    {
        private readonly SubcategoryFinder finder;
        private readonly SubcategoryLister lister;
        private readonly SubcategoryCreator creator;
        private readonly SubcategoryUpdater updater;
        private readonly SubcategoryEraser eraser;

        [HttpGet, Route("{id}")]
        public async Task<ActionResult<Shared.Subcategory>> Get(Guid id)
        {
            var subcategory = await finder.Find(id);
            var result = subcategory.ToDto();
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shared.Category>>> GetAll()
        {
            var categories = await lister.ToList();
            var result = categories.Select(x => x.ToDto());
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Shared.Subcategory>> PostCreate(CreateSubcategory command)
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
