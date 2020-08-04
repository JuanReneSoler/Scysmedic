using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class MotivoDevolucion
    {
        public MotivoDevolucion()
        {
            CompraDetalle = new HashSet<CompraDetalle>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CompraDetalle> CompraDetalle { get; set; }
    }
}
