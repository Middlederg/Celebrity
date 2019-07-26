using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Model
{
    public class ConceptosCategorias
    {
        public string Id { get; set; }
        public string IdConcepto { get; set; }
        public string IdCategoria { get; set; }
    }

    public static class ConceptosCategoriasHelper
    {
        public static IEnumerable<ConceptosCategorias> GetConceptosCategorias(this IEnumerable<Concepto> conceptos)
        {
            foreach (var concepto in conceptos)
            {
                foreach (var categoria in concepto.Categorias)
                {
                    yield return new ConceptosCategorias()
                    {
                        Id = Guid.NewGuid().ToString(),
                        IdCategoria = categoria.Id.ToString(),
                        IdConcepto = concepto.Id.ToString()
                    };
                }
            }
        }
    }
}
