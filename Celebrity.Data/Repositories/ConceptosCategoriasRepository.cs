using Celebrity.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Data.Repositories
{
    public class ConceptosCategoriasRepository : BaseRepository<ConceptosCategorias>
    {
        public IEnumerable<ConceptosCategorias> GetConceptosCategorias()
        {
            return Select("select * from ConceptosCategorias");
        }

        public IEnumerable<ConceptosCategorias> GetConceptosCategorias(string idConcepto)
        {
            return Select($"select * from ConceptosCategorias where IdConcepto = '{idConcepto}'");
        }

        public IEnumerable<ConceptosCategorias> GetConceptosCategorias(IEnumerable<string> categorias)
        {
            return Select($"select * from ConceptosCategorias where IdCategoria in ({string.Join(", ", categorias.Select(x => $"'{x}'"))})");
        }

        public void UpdateCategorias(Concepto concepto)
        {
            ExecuteSql($"DELETE FROM ConceptosCategorias where IdConcepto = '{concepto.Id.ToString()}'");
            foreach (var categoria in concepto.Categorias)
            {
                Insert(new ConceptosCategorias()
                {
                    Id = Guid.NewGuid().ToString(),
                    IdCategoria = categoria.Id.ToString(),
                    IdConcepto = concepto.Id.ToString()
                });
            }
        }
    }
}
