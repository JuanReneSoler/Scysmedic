using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class RecetaDetalle
    {
        public RecetaDetalle()
        {
            CompraDetalle = new HashSet<CompraDetalle>();
        }

        public int Id { get; set; }
        public int RecetaId { get; set; }
        public int MedicamentoId { get; set; }
        public int Cantidad { get; set; }
        public string Aplicacion { get; set; }

        public virtual Medicamento Medicamento { get; set; }
        public virtual Receta Receta { get; set; }
        public virtual ICollection<CompraDetalle> CompraDetalle { get; set; }
    }
}
