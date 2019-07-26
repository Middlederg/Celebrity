using System.Collections.Generic;

namespace Celebrity.Data
{
    public class SeedPrincipal
    {

        public SeedPrincipal()
        {
            var seedCategorias = new SeedCategorias();
            seedCategorias.Seed();
            var seedConceptos = new SeedConceptos(seedCategorias);
            seedConceptos.Seed();
        }
    }
}
