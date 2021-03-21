using Celebrity.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Celebrity.Data
{
    public class SubcategorySeed
    {
        private Subcategory Create(string name, Shared.CategoryValue category)
        {
            return Subcategory.Create(
                name: name,
                category: category);
        }

        private List<Subcategory> famousPeople;
        private List<Subcategory> fictionalfamousPeople;
        private List<Subcategory> culture;
        private List<Subcategory> places;
        private List<Subcategory> cites;
        private List<Subcategory> universes;
        private List<Subcategory> nations;
        private List<Subcategory> technology;
        private List<Subcategory> science;
        private List<Subcategory> sports;

        public SubcategorySeed(ModelBuilder modelBuilder)
        {
            CreateSubcategories();
            modelBuilder.Entity<Subcategory>().HasData(famousPeople);
            modelBuilder.Entity<Subcategory>().HasData(fictionalfamousPeople);
            modelBuilder.Entity<Subcategory>().HasData(culture);
            modelBuilder.Entity<Subcategory>().HasData(places);
            modelBuilder.Entity<Subcategory>().HasData(cites);
            modelBuilder.Entity<Subcategory>().HasData(universes);
            modelBuilder.Entity<Subcategory>().HasData(nations);
            //modelBuilder.Entity<Subcategory>().HasData(tecnologia);
            //modelBuilder.Entity<Subcategory>().HasData(ciencia);
            //modelBuilder.Entity<Subcategory>().HasData(deporte);
        }

        private void CreateSubcategories()
        {
            fictionalfamousPeople = new List<Subcategory>()
            {
                Create("Personaje de ficción", Shared.CategoryValue.FictionalCharacters)
            };
            famousPeople = new List<Subcategory>()
            {
                Create("Antigüedad", Shared.CategoryValue.RealCharacters),
                Create("Medieval", Shared.CategoryValue.RealCharacters),
                Create("Moderno", Shared.CategoryValue.RealCharacters),
                Create("Contemporáneo", Shared.CategoryValue.RealCharacters)
            };

            culture = new List<Subcategory>()
            {
                Create("Películas", Shared.CategoryValue.Culture),
                Create("Series", Shared.CategoryValue.Culture),
                Create("Literatura", Shared.CategoryValue.Culture),
                Create("Teatro", Shared.CategoryValue.Culture),
                Create("Cómic", Shared.CategoryValue.Culture),
                Create("Música", Shared.CategoryValue.Culture),
                Create("Videojuegos", Shared.CategoryValue.Culture),
                Create("Juegos de mesa", Shared.CategoryValue.Culture)
            };

            cites = new List<Subcategory>()
            {
                Create("Citas históricas", Shared.CategoryValue.Quotes),
                Create("Proverbios y refranes", Shared.CategoryValue.Quotes),
                Create("Frases de la tele", Shared.CategoryValue.Quotes)
            };

            places = new List<Subcategory>()
            {
                Create("Paises", Shared.CategoryValue.Places),
                Create("Ciudades", Shared.CategoryValue.Places),
                Create("Ríos", Shared.CategoryValue.Places),
                Create("Montañas", Shared.CategoryValue.Places),
                Create("Mares y lagos", Shared.CategoryValue.Places)
            };

            universes = new List<Subcategory>()
            {
                Create("Star Wars", Shared.CategoryValue.FictionalUniverses),
                Create("Harry Potter", Shared.CategoryValue.FictionalUniverses),
                Create("Los Simpsons", Shared.CategoryValue.FictionalUniverses),
                Create("Marvel", Shared.CategoryValue.FictionalUniverses),
                Create("Disney", Shared.CategoryValue.FictionalUniverses)
            };

            nations = new List<Subcategory>()
            {
                Create("España", Shared.CategoryValue.Nationalities),
                Create("USA", Shared.CategoryValue.Nationalities),
                Create("Reino Unido", Shared.CategoryValue.Nationalities),
                Create("Italia", Shared.CategoryValue.Nationalities),
                Create("Francia", Shared.CategoryValue.Nationalities)
            };
        }

        public Subcategory PersonajesDeFiccion => fictionalfamousPeople[0];
        public Subcategory Antiguedad => famousPeople[0];
        public Subcategory Medieval => famousPeople[1];
        public Subcategory Moderno => famousPeople[2];
        public Subcategory Contemporaneo => famousPeople[3];

        public Subcategory Peliculas => culture[0];
        public Subcategory Series => culture[1];
        public Subcategory Literatura => culture[2];
        public Subcategory Teatro => culture[3];
        public Subcategory Comic => culture[4];
        public Subcategory Musica => culture[5];
        public Subcategory Videojuegos => culture[6];
        public Subcategory JuegosMesa => culture[7];

        public Subcategory Paises => places[0];
        public Subcategory Ciudades => places[1];
        public Subcategory Rios => places[2];
        public Subcategory Montes => places[3];
        public Subcategory MaresLagos => places[4];

        public Subcategory CitasHistoricas => cites[0];
        public Subcategory Proverbios => cites[1];
        public Subcategory FrasesTele => cites[2];

        public Subcategory StarWars => universes[0];
        public Subcategory HarryPotter => universes[1];
        public Subcategory Simpsons => universes[2];
        public Subcategory Marvel => universes[3];
        public Subcategory Disney => universes[4];

        public Subcategory Spain => nations[0];
        public Subcategory USA => nations[1];
        public Subcategory UK => nations[2];
        public Subcategory Italia => nations[3];
        public Subcategory Francia => nations[4];
    }
}
