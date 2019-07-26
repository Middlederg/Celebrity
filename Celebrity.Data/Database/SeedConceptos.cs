using Celebrity.Data.Repositories;
using Celebrity.Model;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Data
{
    public class SeedConceptos : ISeed
    {
        private ConceptosRepository repository;

        private readonly SeedCategorias categorias;

        public SeedConceptos(SeedCategorias categorias)
        {
            this.categorias = categorias;
            repository = new ConceptosRepository();
        }

        public IEnumerable<Concepto> Antiguedad()
        {
            yield return Concepto.Create("Alejandro Magno", Dificultad.Facil, categorias.PersonajesFamosos, categorias.Antiguedad);
            yield return Concepto.Create("Hércules", Dificultad.Facil, categorias.PersonajesFamosos, categorias.Antiguedad);
            yield return Concepto.Create("Amilcar Barca", Dificultad.Media, categorias.PersonajesFamosos, categorias.Antiguedad);
        }

        public void Seed()
        {
            repository.DeleteAll();
            repository.ExecuteSql("delete from ConceptosCategorias");
            repository.InsertarConceptos(Antiguedad().ToList());
        }
    }
}
