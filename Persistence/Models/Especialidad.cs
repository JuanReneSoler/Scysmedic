using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            EmpleadoEspecialidad = new HashSet<EmpleadoEspecialidad>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<EmpleadoEspecialidad> EmpleadoEspecialidad { get; set; }
    }
}
