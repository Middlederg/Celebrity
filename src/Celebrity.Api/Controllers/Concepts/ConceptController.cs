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
        private readonly SubcategoriesInConceptUpdater subcategoryUpdater;
        private readonly ConceptEraser eraser;

        public ConceptController(ConceptFinder finder,
            ConceptLister lister, 
            ConceptCollectionCreator creator, 
            ConceptCollectionUpdater updater,
            SubcategoriesInConceptUpdater subcategoryUpdater,
            ConceptEraser eraser)
        {
            this.finder = finder;
            this.lister = lister;
            this.creator = creator;
            this.updater = updater;
            this.subcategoryUpdater = subcategoryUpdater;
            this.eraser = eraser;
        }

        [HttpGet, Route("concepts/{id}")]
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
            var concepts = await lister.GetFromCategory(id);
            var result = concepts.Select(x => x.ToDto());
            return Ok(result);
        }

        [HttpGet, Route("subcategories/{id}/concepts")]
        public async Task<ActionResult<IEnumerable<Shared.Subcategory>>> GetAllFromSubcategory(Guid id)
        {
            var subcategoryId = new SubcategoryId(id);
            var concepts = await lister.GetFromSubcategory(subcategoryId);
            var result = concepts.Select(x => x.ToDto());
            return Ok(result);
        }

        [HttpPost, Route("concepts")]
        public async Task<IActionResult> Create(IEnumerable<CreateConcept> command)
        {
            var concepts = await creator.Create(command);
            var result = concepts.Select(x => x.ToDto());
            return Ok(result);
        }

        [HttpPatch, Route("concepts")]
        public async Task<IActionResult> Update(IEnumerable<UpdateConcept> command)
        {
            await updater.Edit(command);
            return NoContent();
        }

        [HttpPut, Route("concepts/{id}/subcategories")]
        public async Task<IActionResult> UpdateSubcategories(Guid id, IEnumerable<Guid> subcategoryCollection)
        {
            var conceptId = new ConceptId(id);
            await subcategoryUpdater.Update(conceptId, subcategoryCollection);
            return NoContent();
        }

        [HttpDelete, Route("concepts/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var conceptId = new ConceptId(id);
            await eraser.Delete(conceptId);
            return NoContent();
        }
    }
}
