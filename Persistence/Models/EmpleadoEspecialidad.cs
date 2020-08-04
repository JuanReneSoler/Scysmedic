using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class EmpleadoEspecialidad
    {
        public EmpleadoEspecialidad()
        {
            HospitalEmpleadoUser = new HashSet<HospitalEmpleadoUser>();
        }

        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public int EspecialidadId { get; set; }

        public virtual Empleado1 Empleado { get; set; }
        public virtual Especialidad Especialidad { get; set; }
        public virtual ICollection<HospitalEmpleadoUser> HospitalEmpleadoUser { get; set; }
    }
}
