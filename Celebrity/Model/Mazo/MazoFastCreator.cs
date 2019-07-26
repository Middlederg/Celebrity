using Celebrity.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Model
{
    public class MazoFastCreator : MazoBaseCreator
    {
        public MazoFastCreator(IConceptosRepository repository, ICategoriasRepository categoriasRepository) 
            : base(repository, categoriasRepository) { }
    }
}
