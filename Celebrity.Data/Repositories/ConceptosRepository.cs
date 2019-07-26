using Celebrity.Model;
using Celebrity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Celebrity.Data.Repositories
{
    public class ConceptosRepository : BaseRepository<Conceptos>, IConceptosRepository
    {
        private ConceptosCategoriasRepository categoriasEnConceptosRepository = new ConceptosCategoriasRepository();
        private CategoriasRepository categoriasRepository = new CategoriasRepository();

        public IEnumerable<Concepto> GetConceptos()
        {
            var todoslosConceptosCategorias = categoriasEnConceptosRepository.GetConceptosCategorias().ToList();
            var todasLasCategorias = categoriasRepository.GetCategorias().ToList();
            var todosLosConceptos = Select("select * from Conceptos").ToList();

            foreach (var concepto in todosLosConceptos)
            {
                var idsCategoria = todoslosConceptosCategorias.Where(x => x.IdConcepto.Equals(concepto.Id)).Select(x => x.IdCategoria);
                var categorias = todasLasCategorias.Where(x => idsCategoria.Contains(x.Id.ToString()));
                yield return Concepto.FromDataBase(concepto.Id, concepto.Nombre, Dificultad.FromDatabase(concepto.Dificultad), categorias, concepto.Sistema);
            }
        }

        public IEnumerable<Concepto> GetConceptos(int cantidad, IEnumerable<Categoria> categorias, IEnumerable<Dificultad> dificultades)
        {
            var idsCategorias = categorias.Select(x => x.Id.ToString());
            var conceptosEnCategorias = categoriasEnConceptosRepository.GetConceptosCategorias(idsCategorias).ToList();
            var idsConcepto = conceptosEnCategorias.Select(x => $"'{x.IdConcepto}'").Distinct();
            var todosLosConceptos = Select($"select * from Conceptos where Id in ({string.Join(", ", idsConcepto)}) and Dificultad in ({string.Join(", ", dificultades.Select(x => x.Estrellas))})").ToList();

            foreach (var concepto in todosLosConceptos)
            {
                var idsCategoriaConcreta = conceptosEnCategorias.Where(x => x.IdConcepto.Equals(concepto.Id)).Select(x => x.IdCategoria);
                var categoriasConcretas = categorias.Where(x => idsCategoriaConcreta.Contains(x.Id.ToString()));
                yield return Concepto.FromDataBase(concepto.Id, concepto.Nombre, Dificultad.FromDatabase(concepto.Dificultad), categoriasConcretas, concepto.Sistema);
            }
        }

        public void InsertarConcepto(Concepto concepto, IEnumerable<Categoria> categorias)
        {
            InsertAutonumerico(new Conceptos()
            {
                Id = concepto.Id.ToString(),
                Nombre = concepto.ToString(),
                Sistema = false,
                Dificultad = concepto.Dificultad.Estrellas,
            });

            var conceptosCategorias = categorias.Select(x =>
                new ConceptosCategorias()
                {
                    Id = Guid.NewGuid().ToString(),
                    IdCategoria = x.Id.ToString(),
                    IdConcepto = concepto.Id.ToString()
                });
            categoriasEnConceptosRepository.Insert(conceptosCategorias);
        }

        private void CategoriaEnConcepto(long idConcepto, IEnumerable<long> idCategorias)
        {

        }

        public void InsertarConcepto(Concepto concepto)
        {
            var objeto = new Conceptos()
            {
                Id = concepto.Id.ToString(),
                Nombre = concepto.ToString(),
                Sistema = concepto.Sistema,
                Dificultad = concepto.Dificultad.Estrellas
            };
            Insert(objeto);

            var categoriasEnConceptos = concepto.Categorias.Select(x => 
                new ConceptosCategorias()
                {
                    Id = Guid.NewGuid().ToString(),
                    IdCategoria = x.Id.ToString(),
                    IdConcepto = concepto.Id.ToString()
                }).ToList();
            categoriasEnConceptosRepository.Insert(categoriasEnConceptos);
        }

        public void InsertarConceptos(IEnumerable<Concepto> conceptos)
        {
            var objetos = conceptos.Select(concepto =>
                new Conceptos()
                {
                    Id = concepto.Id.ToString(),
                    Nombre = concepto.ToString(),
                    Sistema = concepto.Sistema,
                    Dificultad = concepto.Dificultad.Estrellas,
                }).ToList();
            Insert(objetos);

            var categoriasEnConceptos = conceptos.GetConceptosCategorias().ToList();
            categoriasEnConceptosRepository.Insert(categoriasEnConceptos);
        }

        public void EditarConcepto(Concepto concepto)
        {
            UpdateRecord(new Conceptos()
            {
                Id = concepto.Id.ToString(),
                Nombre = concepto.ToString(),
                Sistema = concepto.Sistema,
                Dificultad = concepto.Dificultad.Estrellas
            });

            categoriasEnConceptosRepository.UpdateCategorias(concepto);
        }

        public void EliminarConcepto(Guid id) => Delete(id.ToString());
    }
}
