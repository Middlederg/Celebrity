using Celebrity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Model
{

    public class MazoCreator : MazoBaseCreator
    {
        public MazoCreator(IConceptosRepository repository, IEnumerable<Categoria> categorias, 
            IEnumerable<Dificultad> dificultad, int numeroConceptos) : base(repository, categorias, dificultad, numeroConceptos)
        {
            if (categorias.Count() < 1)
                throw new ArgumentException("Hay que seleccionar por lo menos una categoría");
        }
    }
}
