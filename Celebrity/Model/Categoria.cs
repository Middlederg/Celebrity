using System;

namespace Celebrity.Model
{
    public class Categoria : Identity
    {
        private string nombre;
        public void CambiarNombre(string nuevoValor) => nombre = nuevoValor;

        public Guid? Parent { get; private set; }
        public void CambiarPadre(Guid? nuevoValor) => Parent = nuevoValor;
        public bool HasParent => Parent.HasValue && !Parent.Value.Equals(Guid.Empty);
        public string ParentToString => HasParent ? Parent.Value.ToString() : null;
        public bool IsChildOf(Guid parent) => Parent.HasValue && Parent.Value.Equals(parent);

        public bool Sistema { get; private set; }

        public static Categoria FromDataBase(string id, string nombre, bool sistema, string parent)
            => new Categoria(new Guid(id), nombre, sistema, parent != null ? new Guid(parent) : (Guid?)null);

        public static Categoria Create(string nombre, Guid? parent = null) => new Categoria(Guid.NewGuid(), nombre, false, parent);

        private Categoria(Guid id, string nombre, bool sistema, Guid? parent) : base(id)
        {
            this.nombre = nombre;
            Sistema = sistema;
            Parent = parent;
        }


        public override string ToString() => nombre;
    }
}
