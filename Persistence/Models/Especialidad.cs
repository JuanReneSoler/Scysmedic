using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            HospitalEmpleadoEspecialidad = new HashSet<HospitalEmpleadoEspecialidad>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<HospitalEmpleadoEspecialidad> HospitalEmpleadoEspecialidad { get; set; }
    }
}
