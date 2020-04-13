using System;
using System.Collections.Generic;

namespace Celebrity.Data
{
    public class SubcategoriasCreator
    {
        private Subcategories Create(string name)
        {
            return new Subcategories()
            {
                Id = Guid.NewGuid(),
                Name = name,
                IsCustomized = false
            };
        }

        public List<Subcategories> personajesFamosos;
        public List<Subcategories> personajesDeFiccionFamosos;
        public List<Subcategories> cultura;
        public List<Subcategories> lugares;
        public List<Subcategories> citas;
        public List<Subcategories> universos;
        public List<Subcategories> nacionalidades;
        public List<Subcategories> tecnologia;
        public List<Subcategories> ciencia;
        public List<Subcategories> deporte;

        public SubcategoriasCreator()
        {
            personajesDeFiccionFamosos = new List<Subcategories>()
            {
                Create("Personaje de ficción")
            };
            personajesFamosos = new List<Subcategories>()
            {
                Create("Antigüedad"),
                Create("Medieval"),
                Create("Moderno"),
                Create("Contemporáneo")
            };

            cultura = new List<Subcategories>()
            {
                Create("Películas"),
                Create("Series"),
                Create("Literatura"),
                Create("Teatro"),
                Create("Cómic"),
                Create("Música"),
                Create("Videojuegos"),
                Create("Juegos de mesa")
            };

            citas = new List<Subcategories>()
            {
                Create("Citas históricas"),
                Create("Proverbios y refranes"),
                Create("Frases de la tele")
            };

            lugares = new List<Subcategories>()
            {
                Create("Paises"),
                Create("Ciudades"),
                Create("Ríos"),
                Create("Montañas"),
                Create("Mares y lagos")
            };

            universos = new List<Subcategories>()
            {
                Create("Star Wars"),
                Create("Harry Potter"),
                Create("Los Simpsons"),
                Create("Marvel"),
                Create("Disney")
            };

            universos = new List<Subcategories>()
            {
                Create("España"),
                Create("USA"),
                Create("Reino Unido"),
                Create("Italia"),
                Create("Francia")
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
