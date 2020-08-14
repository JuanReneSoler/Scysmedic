using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Aseguradora
    {
        public Aseguradora()
        {
            SeguroHistorial = new HashSet<SeguroHistorial>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<SeguroHistorial> SeguroHistorial { get; set; }
    }
}
