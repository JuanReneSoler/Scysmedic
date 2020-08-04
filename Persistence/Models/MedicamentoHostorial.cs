using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class MedicamentoHostorial
    {
        public int Id { get; set; }
        public int MedicamentoId { get; set; }
        public int SuplidorId { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int CantidadAdquirida { get; set; }
        public int CantidadActual { get; set; }
        public int PrecioCompra { get; set; }
        public int PrecioVenta { get; set; }
        public int Itebis { get; set; }

        public virtual Medicamento Medicamento { get; set; }
        public virtual Suplidor Suplidor { get; set; }
    }
}
