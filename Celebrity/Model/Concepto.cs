using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Model
{
    public class Concepto : Identity
    {
        private string nombre;
        public void CambiarNombre(string value) => nombre = value;
        
        public Dificultad Dificultad { get; private set; }
        public void CambiarDificultad(Dificultad value) => Dificultad = value;

        public bool Sistema { get; }

        public IEnumerable<Categoria> Categorias { get; private set; }
        public void EditarCategorias(IEnumerable<Categoria> value) => Categorias = value;
        public bool TieneCategoria(Categoria categoria) => Categorias.Any(x => x.Equals(categoria));
        public bool TieneCategoria(string idCategoria) => Categorias.Any(x => x.Id.ToString().Equals(idCategoria));

        public bool Acertada { get; private set; }
        public void Acertar() => Acertada = true;
        public void Reiniciar() => Acertada = false;

        public static Concepto Create(string nombre, Dificultad dificultad, IEnumerable<Categoria> categorias)
             => new Concepto(Guid.NewGuid(), nombre, dificultad, categorias, false);

        public static Concepto Create(string nombre, Dificultad dificultad, params Categoria[] categorias)
             => new Concepto(Guid.NewGuid(), nombre, dificultad, categorias, false);

        public static Concepto FromDataBase(string id, string nombre, Dificultad dificultad, IEnumerable<Categoria> categorias, bool sistema) 
            => new Concepto(new Guid(id), nombre, dificultad, categorias, sistema);

        private Concepto(Guid id, string nombre, Dificultad dificultad, IEnumerable<Categoria> categorias, 
            bool sistema) : base(id)
        {
            this.nombre = nombre;
            Sistema = sistema;
            Dificultad = dificultad;
            Categorias = categorias;
            Acertada = false;
        }

        public override string ToString() => nombre.ToString();

        public override bool Equals(object obj)
        {
            if (obj is Concepto t)
                return t.nombre.Equals(nombre);
            return false;
        }

        public override int GetHashCode() => nombre.GetHashCode();
    }
}
