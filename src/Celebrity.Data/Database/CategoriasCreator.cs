using Celebrity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Data
{
    public class CategoriasCreator
    {
        public Categories Create(string name)
        {
            return new Categories()
            {
                Id = Guid.NewGuid(),
                Name = name
            };
        }

        public List<Categories> categorias;

        public CategoriasCreator()
        {
            categorias = CreateCategorias();
        }

        private List<Categories> CreateCategorias()
        {
            return new List<Categories>()
            {
                Create("Personajes famosos"),
                Create("Personajes de ficción famosos"),
                Create("Cultura"),
                Create("Lugares"),
                Create("Citas"),
                Create("Universos de ficción"),
                Create("Nacionalidades"),
                Create("Tecnología"),
                Create("Ciencia"),
                Create("Deporte")
            };
        }

        public Categories PersonajesFamosos => categorias[0];
        public Categories PersonajesFiccion => categorias[1];
        public Categories Cultura => categorias[2];
        public Categories Lugares => categorias[3];
        public Categories Citas => categorias[4];
        public Categories Universos => categorias[5];
        public Categories Nacionalidades => categorias[6];
        public Categories Tecnología => categorias[7];
        public Categories Ciencia => categorias[8];
        public Categories Deporte => categorias[9];
    }
}
