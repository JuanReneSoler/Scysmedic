using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class CompraDetalle
    {
        public int Id { get; set; }
        public int CompraId { get; set; }
        public int MedicamentoRecetaId { get; set; }
        public int Cantidad { get; set; }
        public int PrecionCompra { get; set; }
        public int Itebis { get; set; }
        public int MotivoDevolucionId { get; set; }
        public string Descripcion { get; set; }

        public virtual Compra Compra { get; set; }
        public virtual RecetaDetalle MedicamentoReceta { get; set; }
        public virtual MotivoDevolucion MotivoDevolucion { get; set; }
    }
}
