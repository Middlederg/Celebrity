using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Celebrity.Data
{
    public class SubcategoryCreator
    {
        private Subcategories Create(string name, CategoryValue category)
        {
            return new Subcategories()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Category = category
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

        public SubcategoryCreator(ModelBuilder modelBuilder)
        {
            CreateSubcategories();
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

        private void CreateSubcategories()
        {
            personajesDeFiccionFamosos = new List<Subcategories>()
            {
                Create("Personaje de ficción", CategoryValue.FictionalCharacters)
            };
            personajesFamosos = new List<Subcategories>()
            {
                Create("Antigüedad", CategoryValue.RealCharacters),
                Create("Medieval", CategoryValue.RealCharacters),
                Create("Moderno", CategoryValue.RealCharacters),
                Create("Contemporáneo", CategoryValue.RealCharacters)
            };

            cultura = new List<Subcategories>()
            {
                Create("Películas", CategoryValue.Culture),
                Create("Series", CategoryValue.Culture),
                Create("Literatura", CategoryValue.Culture),
                Create("Teatro", CategoryValue.Culture),
                Create("Cómic", CategoryValue.Culture),
                Create("Música", CategoryValue.Culture),
                Create("Videojuegos", CategoryValue.Culture),
                Create("Juegos de mesa", CategoryValue.Culture)
            };

            citas = new List<Subcategories>()
            {
                Create("Citas históricas", CategoryValue.Quotes),
                Create("Proverbios y refranes", CategoryValue.Quotes),
                Create("Frases de la tele", CategoryValue.Quotes)
            };

            lugares = new List<Subcategories>()
            {
                Create("Paises", CategoryValue.Places),
                Create("Ciudades", CategoryValue.Places),
                Create("Ríos", CategoryValue.Places),
                Create("Montañas", CategoryValue.Places),
                Create("Mares y lagos", CategoryValue.Places)
            };

            universos = new List<Subcategories>()
            {
                Create("Star Wars", CategoryValue.FictionalUniverses),
                Create("Harry Potter", CategoryValue.FictionalUniverses),
                Create("Los Simpsons", CategoryValue.FictionalUniverses),
                Create("Marvel", CategoryValue.FictionalUniverses),
                Create("Disney", CategoryValue.FictionalUniverses)
            };

            nacionalidades = new List<Subcategories>()
            {
                Create("España", CategoryValue.Nationalities),
                Create("USA", CategoryValue.Nationalities),
                Create("Reino Unido", CategoryValue.Nationalities),
                Create("Italia", CategoryValue.Nationalities),
                Create("Francia", CategoryValue.Nationalities)
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
