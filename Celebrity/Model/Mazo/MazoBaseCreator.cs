using Celebrity.Repositories;
using System.Collections.Generic;

namespace Celebrity.Model
{
    public abstract class MazoBaseCreator
    {
        private readonly IConceptosRepository repository;
        protected IEnumerable<Categoria> Categorias { get; }
        protected IEnumerable<Dificultad> Dificultades { get; }
        public int NumeroConceptos { get; set; }

        protected MazoBaseCreator(IConceptosRepository repository, IEnumerable<Categoria> categorias, IEnumerable<Dificultad> dificultad, int numeroConceptos)
        {
            this.repository = repository;
            Categorias = categorias;
            Dificultades = dificultad ?? TodasLasDificultades();
            NumeroConceptos = numeroConceptos;
        }

        protected MazoBaseCreator(IConceptosRepository repository, ICategoriasRepository categoriasRepository)
        {
            this.repository = repository;
            Categorias = categoriasRepository.GetCategorias();
            Dificultades = TodasLasDificultades();
        }

        public IEnumerable<Concepto> Create()
        {
            return repository.GetConceptos(NumeroConceptos, Categorias, Dificultades);
        }

        private IEnumerable<Dificultad> TodasLasDificultades()
        {
            return new List<Dificultad> { Dificultad.Facil, Dificultad.Media, Dificultad.Dificil };
        }
    }
}
