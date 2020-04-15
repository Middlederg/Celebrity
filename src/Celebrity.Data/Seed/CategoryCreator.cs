using Celebrity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Data
{
    public class CategoryCreator
    {
        public Categories Create(string name)
        {
            return new Categories()
            {
                Id = Guid.NewGuid(),
                Name = name
            };
        }

        private readonly List<Categories> categories;

        public CategoryCreator(ModelBuilder modelBuilder)
        {
            categories = CreateCategorias();
            foreach (var category in categories)
            {
                modelBuilder.Entity<Categories>().HasData(category);
            }
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

        public Categories PersonajesFamosos => categories[0];
        public Categories PersonajesFiccion => categories[1];
        public Categories Cultura => categories[2];
        public Categories Lugares => categories[3];
        public Categories Citas => categories[4];
        public Categories Universos => categories[5];
        public Categories Nacionalidades => categories[6];
        public Categories Tecnología => categories[7];
        public Categories Ciencia => categories[8];
        public Categories Deporte => categories[9];
    }
}
