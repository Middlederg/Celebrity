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
    [Route("api")]
    public class ConceptController : ControllerBase
    {
        private readonly ConceptFinder finder;
        private readonly ConceptLister lister;
        private readonly ConceptCollectionCreator creator;
        private readonly ConceptCollectionUpdater updater;
        private readonly ConceptEraser eraser;

        [HttpGet, Route("{id}")]
        public async Task<ActionResult<Shared.Subcategory>> Get(Guid id)
        {
            var conceptId = new ConceptId(id);
            var concept = await finder.Find(conceptId);
            var result = concept.ToDto();
            return Ok(result);
        }

        [HttpGet, Route("categories/{id:int}/concepts")]
        public async Task<ActionResult<IEnumerable<Shared.Subcategory>>> GetAllFromCategory(int id)
        {
            var categories = await lister.GetFromCategory(id);
            var result = categories.Select(x => x.ToDto());
            return Ok(result);
        }

        [HttpGet, Route("subcategories/{id:Guid}/concepts")]
        public async Task<ActionResult<IEnumerable<Shared.Subcategory>>> GetAllFromSubcategory(Guid id)
        {
            var subcategoryId = new SubcategoryId(id);
            var categories = await lister.GetFromSubcategory(subcategoryId);
            var result = categories.Select(x => x.ToDto());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(IEnumerable<CreateConcept> command)
        {
            await creator.Create(command);
            return Ok();
        }

        [HttpPatch]
        public async Task<IActionResult> Update(IEnumerable<UpdateConcept> command)
        {
            await updater.Edit(command);
            return NoContent();
        }

        [HttpDelete, Route("{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var conceptId = new ConceptId(id);
            await eraser.Delete(conceptId);
            return NoContent();
        }
    }
}
