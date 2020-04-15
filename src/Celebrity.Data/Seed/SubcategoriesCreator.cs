using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Celebrity.Data
{
    public class SubcategoryCreator
    {
        private Subcategories Create(string name, Categories category)
        {
            return new Subcategories()
            {
                Id = Guid.NewGuid(),
                Name = name,
                IsCustomized = false,
                IdCategory = category.Id
            };
        }

        private List<Subcategories> personajesFamosos;
        private List<Subcategories> personajesDeFiccionFamosos;
        private List<Subcategories> cultura;
        private List<Subcategories> lugares;
        private List<Subcategories> citas;
        private List<Subcategories> universos;
        private List<Subcategories> nacionalidades;
        private List<Subcategories> tecnologia;
        private List<Subcategories> ciencia;
        private List<Subcategories> deporte;

        public SubcategoryCreator(ModelBuilder modelBuilder, CategoryCreator categoryCreator)
        {
            CreateSubcategories(categoryCreator);
            modelBuilder.Entity<Subcategories>().HasData(personajesFamosos);
            modelBuilder.Entity<Subcategories>().HasData(personajesDeFiccionFamosos);
            modelBuilder.Entity<Subcategories>().HasData(cultura);
            modelBuilder.Entity<Subcategories>().HasData(lugares);
            modelBuilder.Entity<Subcategories>().HasData(citas);
            modelBuilder.Entity<Subcategories>().HasData(universos);
            modelBuilder.Entity<Subcategories>().HasData(nacionalidades);
            //modelBuilder.Entity<Subcategories>().HasData(tecnologia);
            //modelBuilder.Entity<Subcategories>().HasData(ciencia);
            //modelBuilder.Entity<Subcategories>().HasData(deporte);
        }

        private void CreateSubcategories(CategoryCreator categoryCreator)
        {
            personajesDeFiccionFamosos = new List<Subcategories>()
            {
                Create("Personaje de ficción", categoryCreator.PersonajesFiccion)
            };
            personajesFamosos = new List<Subcategories>()
            {
                Create("Antigüedad", categoryCreator.PersonajesFamosos),
                Create("Medieval", categoryCreator.PersonajesFamosos),
                Create("Moderno", categoryCreator.PersonajesFamosos),
                Create("Contemporáneo", categoryCreator.PersonajesFamosos)
            };

            cultura = new List<Subcategories>()
            {
                Create("Películas", categoryCreator.Cultura),
                Create("Series", categoryCreator.Cultura),
                Create("Literatura", categoryCreator.Cultura),
                Create("Teatro", categoryCreator.Cultura),
                Create("Cómic", categoryCreator.Cultura),
                Create("Música", categoryCreator.Cultura),
                Create("Videojuegos", categoryCreator.Cultura),
                Create("Juegos de mesa", categoryCreator.Cultura)
            };

            citas = new List<Subcategories>()
            {
                Create("Citas históricas", categoryCreator.Citas),
                Create("Proverbios y refranes", categoryCreator.Citas),
                Create("Frases de la tele", categoryCreator.Citas)
            };

            lugares = new List<Subcategories>()
            {
                Create("Paises", categoryCreator.Lugares),
                Create("Ciudades", categoryCreator.Lugares),
                Create("Ríos", categoryCreator.Lugares),
                Create("Montañas", categoryCreator.Lugares),
                Create("Mares y lagos", categoryCreator.Lugares)
            };

            universos = new List<Subcategories>()
            {
                Create("Star Wars", categoryCreator.Universos),
                Create("Harry Potter", categoryCreator.Universos),
                Create("Los Simpsons", categoryCreator.Universos),
                Create("Marvel", categoryCreator.Universos),
                Create("Disney", categoryCreator.Universos)
            };

            nacionalidades = new List<Subcategories>()
            {
                Create("España", categoryCreator.Nacionalidades),
                Create("USA", categoryCreator.Nacionalidades),
                Create("Reino Unido", categoryCreator.Nacionalidades),
                Create("Italia", categoryCreator.Nacionalidades),
                Create("Francia", categoryCreator.Nacionalidades)
            };
        }

        public Subcategories PersonajesDeFiccion => personajesDeFiccionFamosos[0];
        public Subcategories Antiguedad => personajesFamosos[0];
        public Subcategories Medieval => personajesFamosos[1];
        public Subcategories Moderno => personajesFamosos[2];
        public Subcategories Contemporaneo => personajesFamosos[3];

        public Subcategories Peliculas => cultura[0];
        public Subcategories Series => cultura[1];
        public Subcategories Literatura => cultura[2];
        public Subcategories Teatro => cultura[3];
        public Subcategories Comic => cultura[4];
        public Subcategories Musica => cultura[5];
        public Subcategories Videojuegos => cultura[6];
        public Subcategories JuegosMesa => cultura[7];

        public Subcategories Paises => lugares[0];
        public Subcategories Ciudades => lugares[1];
        public Subcategories Rios => lugares[2];
        public Subcategories Montes => lugares[3];
        public Subcategories MaresLagos => lugares[4];

        public Subcategories CitasHistoricas => citas[0];
        public Subcategories Proverbios => citas[1];
        public Subcategories FrasesTele => citas[2];

        public Subcategories StarWars => universos[0];
        public Subcategories HarryPotter => universos[1];
        public Subcategories Simpsons => universos[2];
        public Subcategories Marvel => universos[3];
        public Subcategories Disney => universos[4];

        public Subcategories Spain => nacionalidades[0];
        public Subcategories USA => nacionalidades[1];
        public Subcategories UK => nacionalidades[2];
        public Subcategories Italia => nacionalidades[3];
        public Subcategories Francia => nacionalidades[4];
    }
}
