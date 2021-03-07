using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class HospitalEmpleadoUser
    {
        public HospitalEmpleadoUser()
        {
            Citas = new HashSet<Citas>();
        }

        public int Id { get; set; }
        public int HospitalId { get; set; }
        public int EmpleadoId { get; set; }
        public int EspecialidadId { get; set; }
        public DateTime FechaAfiliacion { get; set; }

        public virtual HospitalEmpleado Empleado { get; set; }
        public virtual HospitalEmpleadoEspecialidad Especialidad { get; set; }
        public virtual HospitalUser Hospital { get; set; }
        public virtual ICollection<Citas> Citas { get; set; }
    }
}
