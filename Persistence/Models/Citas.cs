using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Citas
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int HospitalId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual HospitalEmpleadoUser Empleado { get; set; }
        public virtual HospitalUser Hospital { get; set; }
    }
}
