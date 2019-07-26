using Celebrity.Data.Repositories;
using Celebrity.Model;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Data
{
    public class SeedCategorias : ISeed
    {
        private readonly List<Categoria> subcategorias;

        public SeedCategorias()
        {
            subcategorias = CreateSubCategorias().ToList();
        }

        private readonly List<Categoria> categorias = new List<Categoria>()
        {
            Categoria.Create("Personajes famosos"),
            Categoria.Create("Personajes de ficción famosos"),
            Categoria.Create("Cultura"),
            Categoria.Create("Lugares"),
            Categoria.Create("Citas"),
            Categoria.Create("Universos de ficción"),
            Categoria.Create("Nacionalidades"),
            Categoria.Create("Tecnología"),
            Categoria.Create("Ciencia"),
            Categoria.Create("Deporte")
       };

        public Categoria PersonajesFamosos => categorias[0];
        public Categoria PersonajesFiccion => categorias[1];
        public Categoria Cultura => categorias[2];
        public Categoria Lugares => categorias[3];
        public Categoria Citas => categorias[4];
        public Categoria Universos => categorias[5];
        public Categoria Nacionalidades => categorias[6];
        public Categoria Tecnología => categorias[7];
        public Categoria Ciencia => categorias[8];
        public Categoria Deporte => categorias[9];

        private IEnumerable<Categoria> CreateSubCategorias()
        {
            yield return Categoria.Create("Antigüedad", PersonajesFamosos.Id);
            yield return Categoria.Create("Medieval", PersonajesFamosos.Id);
            yield return Categoria.Create("Moderno", PersonajesFamosos.Id);
            yield return Categoria.Create("Contemporáneo", PersonajesFamosos.Id);
            yield return Categoria.Create("Películas", Cultura.Id);
            yield return Categoria.Create("Series", Cultura.Id);
            yield return Categoria.Create("Literatura", Cultura.Id);
            yield return Categoria.Create("Teatro", Cultura.Id);
            yield return Categoria.Create("Cómic", Cultura.Id);
            yield return Categoria.Create("Música", Cultura.Id);
            yield return Categoria.Create("Videojuegos", Cultura.Id);
            yield return Categoria.Create("Juegos de mesa", Cultura.Id);
            yield return Categoria.Create("Paises", Lugares.Id);
            yield return Categoria.Create("Ciudades", Lugares.Id);
            yield return Categoria.Create("Ríos", Lugares.Id);
            yield return Categoria.Create("Montañas", Lugares.Id);
            yield return Categoria.Create("Mares y lagos", Lugares.Id);
            yield return Categoria.Create("Citas históricas", Citas.Id);
            yield return Categoria.Create("Proverbios y refranes", Citas.Id);
            yield return Categoria.Create("Frases de la tele", Citas.Id);
            yield return Categoria.Create("Star Wars", Universos.Id);
            yield return Categoria.Create("Harry Potter", Universos.Id);
            yield return Categoria.Create("Los Simpsons", Universos.Id);
            yield return Categoria.Create("Marvel", Universos.Id);
            yield return Categoria.Create("Disney", Universos.Id);
            yield return Categoria.Create("España", Nacionalidades.Id);
            yield return Categoria.Create("USA", Nacionalidades.Id);
            yield return Categoria.Create("Reino Unido", Nacionalidades.Id);
            yield return Categoria.Create("Italia", Nacionalidades.Id);
            yield return Categoria.Create("Francia", Nacionalidades.Id);
        }

        public Categoria Antiguedad => subcategorias[0];
        public Categoria Medieval => subcategorias[1];
        public Categoria Moderno => subcategorias[2];
        public Categoria Contemporaneo => subcategorias[3];
        public Categoria Peliculas => subcategorias[4];
        public Categoria Series => subcategorias[5];
        public Categoria Literatura => subcategorias[6];
        public Categoria Teatro => subcategorias[7];
        public Categoria Comic => subcategorias[8];
        public Categoria Musica => subcategorias[9];
        public Categoria Videojuegos => subcategorias[10];
        public Categoria JuegosMesa => subcategorias[11];
        public Categoria Paises => subcategorias[12];
        public Categoria Ciudades => subcategorias[13];
        public Categoria Rios => subcategorias[14];
        public Categoria Montes => subcategorias[15];
        public Categoria MaresLagos => subcategorias[16];
        public Categoria CitasHistoricas => subcategorias[17];
        public Categoria Proverbios => subcategorias[18];
        public Categoria FrasesTele => subcategorias[19];
        public Categoria StarWars => subcategorias[20];
        public Categoria HarryPotter => subcategorias[21];
        public Categoria Simpsons => subcategorias[22];
        public Categoria Marvel => subcategorias[23];
        public Categoria Disney => subcategorias[24];
        public Categoria Spain => subcategorias[25];
        public Categoria USA => subcategorias[26];
        public Categoria UK => subcategorias[27];
        public Categoria Italia => subcategorias[28];
        public Categoria Francia => subcategorias[29];

        public void Seed()
        {
            var repository = new CategoriasRepository();
            repository.DeleteAll();
            repository.InsertarCategorias(categorias);
            repository.InsertarCategorias(subcategorias);
        }
    }
}
