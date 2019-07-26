using Celebrity.Model;
using Celebrity.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace Celebrity.Data.Repositories
{
    public class CategoriasRepository : BaseRepository<Categorias>, ICategoriasRepository
    {
        public Categoria GetCategoria(Guid id)
        {
            var categoria = Select($"Select * from Categorias where Id = '{id.ToString()}'").FirstOrDefault();
            return Categoria.FromDataBase(categoria.Id, categoria.Nombre, categoria.Sistema, categoria.Parent);
        }

        public IEnumerable<Categoria> GetCategorias()
        {
            var categorias = Select("Select * from Categorias").ToList();

            foreach (var categoria in categorias)
                yield return Categoria.FromDataBase(categoria.Id, categoria.Nombre, categoria.Sistema, categoria.Parent);
        }

        public IEnumerable<Categoria> GetCategoriasPorId(IEnumerable<string> ids)
        {
            var categorias = Select($"Select * from Categorias where Id in ({string.Join(", ", ids.Select(x => $"'{x}'"))})").ToList();

            foreach (var categoria in categorias)
                yield return Categoria.FromDataBase(categoria.Id, categoria.Nombre, categoria.Sistema, categoria.Parent);
        }

        public IEnumerable<Categoria> GetCategoriasPorNombre(IEnumerable<string> nombres)
        {
            var categorias = Select($"Select * from Categorias where UPPER(Nombre) in({string.Join(", ", nombres.Select(x => $"'{x}'"))})").ToList();

            foreach (var categoria in categorias)
                yield return Categoria.FromDataBase(categoria.Id, categoria.Nombre, categoria.Sistema, categoria.Parent);
        }

        public IEnumerable<ComboBaseItem> GetComboItemsCategorias()
        {
            var categorias = Select("Select * from Categorias where Parent is null").ToList();
            foreach (var item in categorias)
            {
                yield return new ComboBaseItem()
                {
                    Text = item.Nombre,
                    Value = item.Id
                };
            }
        }

        public IEnumerable<ComboBaseItem> GetComboItemsSubcategorias()
        {
            var categorias = Select("Select * from Categorias where Parent is not Null").ToList();
            foreach (var item in categorias)
            {
                yield return new ComboBaseItem()
                {
                    Text = item.Nombre,
                    Value = item.Id
                };
            }
        }

        public IEnumerable<ComboBaseItem> GetComboItemsAll()
        {
            var categorias = GetComboItemsCategorias();
            var subcategorias = GetComboItemsSubcategorias();
            return categorias.Concat(subcategorias).ToList();
        }

        public void InsertarCategoria(Categoria categoria)
        {
            Insert(new Categorias()
            {
                Id = categoria.Id.ToString(),
                Nombre = categoria.ToString(),
                Sistema = categoria.Sistema,
                Parent = categoria.ParentToString
            });
        }

        public void InsertarCategorias(IEnumerable<Categoria> categorias)
        {
            var objetos = categorias.Select(categoria =>
                new Categorias()
                {
                    Id = categoria.Id.ToString(),
                    Nombre = categoria.ToString(),
                    Sistema = categoria.Sistema,
                    Parent = categoria.ParentToString
                }).ToList();
            Insert(objetos);
        }

        //public void InsertarCategoriasSiNoExisten(IEnumerable<string> categorias)
        //{
        //    categorias = categorias.Select(x => x.ToUpper()).Distinct();

        //    var categoriasExistentes = GetCategoriasPorNombre(categorias).Select(x => x.ToString().ToUpper()).Distinct().ToList();

        //    foreach (var c in categorias)
        //    {
        //        if (!categoriasExistentes.Contains(c))
        //        {
        //            //Categoria.Create()
        //        }
        //    }
        //}

        public void EditarCategoria(Categoria categoria)
        {
            UpdateRecord(new Categorias()
            {
                Id = categoria.Id.ToString(),
                Nombre = categoria.ToString(),
                Sistema = categoria.Sistema,
                Parent = categoria.ParentToString
            });
        }

        public void EliminarCategoria(Guid id) => Delete(id.ToString());
    }
}
