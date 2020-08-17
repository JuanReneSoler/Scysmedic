using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Receta
    {
        public Receta()
        {
            Compra = new HashSet<Compra>();
            RecetaDetalle = new HashSet<RecetaDetalle>();
        }

        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UserId { get; set; }
        public int EmpleadoId { get; set; }

        public virtual HospitalEmpleado Empleado { get; set; }
        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<RecetaDetalle> RecetaDetalle { get; set; }
    }
}
