using Celebrity.Model;
using System;
using System.Collections.Generic;

namespace Celebrity.Repositories
{
    public interface ICategoriasRepository
    {
        Categoria GetCategoria(Guid id);
        IEnumerable<Categoria> GetCategorias();
        IEnumerable<ComboBaseItem> GetComboItemsCategorias();
        IEnumerable<ComboBaseItem> GetComboItemsSubcategorias();
        IEnumerable<ComboBaseItem> GetComboItemsAll();
        IEnumerable<Categoria> GetCategoriasPorId(IEnumerable<string> ids);
        IEnumerable<Categoria> GetCategoriasPorNombre(IEnumerable<string> nombres);

        void InsertarCategoria(Categoria categoria);
        void InsertarCategorias(IEnumerable<Categoria> categorias);
        void EditarCategoria(Categoria categoria);
        void EliminarCategoria(Guid id);
    }
}
