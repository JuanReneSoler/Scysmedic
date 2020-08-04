using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Cargo2
    {
        public Cargo2()
        {
            EmpleadoHistorial2 = new HashSet<EmpleadoHistorial2>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<EmpleadoHistorial2> EmpleadoHistorial2 { get; set; }
    }
}
