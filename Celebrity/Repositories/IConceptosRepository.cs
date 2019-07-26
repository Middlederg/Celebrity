using Celebrity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Celebrity.Repositories
{
    public interface IConceptosRepository
    {
        IEnumerable<Concepto> GetConceptos();
        IEnumerable<Concepto> GetConceptos(int cantidad, IEnumerable<Categoria> categorias = null, IEnumerable<Dificultad> dificultad = null);

        void InsertarConcepto(Concepto concepto);
        void InsertarConceptos(IEnumerable<Concepto> conceptos);
        void EditarConcepto(Concepto concepto);
        void EliminarConcepto(Guid id);
    }
}
