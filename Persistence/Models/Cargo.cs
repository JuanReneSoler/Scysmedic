using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Cargo
    {
        public Cargo()
        {
            EmpleadoHistorial = new HashSet<EmpleadoHistorial>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<EmpleadoHistorial> EmpleadoHistorial { get; set; }
    }
}
