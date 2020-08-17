using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class TipoPago
    {
        public TipoPago()
        {
            Compra = new HashSet<Compra>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Compra> Compra { get; set; }
    }
}
