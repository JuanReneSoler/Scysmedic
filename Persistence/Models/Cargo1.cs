using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Cargo1
    {
        public Cargo1()
        {
            EmpleadoHistorial1 = new HashSet<EmpleadoHistorial1>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<EmpleadoHistorial1> EmpleadoHistorial1 { get; set; }
    }
}
