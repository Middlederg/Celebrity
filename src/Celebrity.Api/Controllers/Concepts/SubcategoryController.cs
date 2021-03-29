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
    [Route(SubcategoryEndpoints.Base)]
    public class SubcategoryController : ControllerBase
    {
        private readonly SubcategoryFinder finder;
        private readonly SubcategoryLister lister;
        private readonly SubcategoryCreator creator;
        private readonly SubcategoryUpdater updater;
        private readonly SubcategoryEraser eraser;

        public SubcategoryController(SubcategoryFinder finder, 
            SubcategoryLister lister,
            SubcategoryCreator creator, 
            SubcategoryUpdater updater, 
            SubcategoryEraser eraser)
        {
            this.finder = finder;
            this.lister = lister;
            this.creator = creator;
            this.updater = updater;
            this.eraser = eraser;
        }

        [HttpGet, Route("{id}")]
        public async Task<ActionResult<Shared.Subcategory>> Get(Guid id)
        {
            var subcategoryId = new SubcategoryId(id);
            var subcategory = await finder.Find(subcategoryId);
            var result = subcategory.ToDto();
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shared.Subcategory>>> GetAll()
        {
            var categories = await lister.ToList();
            var result = categories.Select(x => x.ToDto());
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Shared.Subcategory>> Create(CreateSubcategory command)
        {
            var subcategory = await creator.Create(command);
            var result = subcategory.ToDto();
            return CreatedAtAction(nameof(Get), new { id = subcategory.Id }, result);
        }

        [HttpPatch, Route("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateSubcategory command)
        {
            var subcategoryId = new SubcategoryId(id);
            await updater.Edit(subcategoryId, command);
            return NoContent();
        }

        [HttpDelete, Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var subcategoryId = new SubcategoryId(id);
            await eraser.Delete(subcategoryId);
            return NoContent();
        }
    }
}
