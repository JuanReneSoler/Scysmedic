using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Compra
    {
        public Compra()
        {
            CompraDetalle = new HashSet<CompraDetalle>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public int FarmaciaId { get; set; }
        public int RecetaId { get; set; }
        public DateTime FechaCompra { get; set; }
        public string CodigoVerificacion { get; set; }
        public int PrecioPagar { get; set; }
        public int TipoPago { get; set; }

        public virtual FarmaciaUser Farmacia { get; set; }
        public virtual Receta Receta { get; set; }
        public virtual TipoPago TipoPagoNavigation { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<CompraDetalle> CompraDetalle { get; set; }
    }
}
