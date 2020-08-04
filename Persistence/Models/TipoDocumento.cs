using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Empleado = new HashSet<Empleado>();
            Empleado1 = new HashSet<Empleado1>();
            Empleado2 = new HashSet<Empleado2>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
        public virtual ICollection<Empleado1> Empleado1 { get; set; }
        public virtual ICollection<Empleado2> Empleado2 { get; set; }
    }
}
