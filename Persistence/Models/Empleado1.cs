using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Empleado1
    {
        public Empleado1()
        {
            EmpleadoEspecialidad = new HashSet<EmpleadoEspecialidad>();
            EmpleadoHistorial1 = new HashSet<EmpleadoHistorial1>();
            HospitalEmpleadoUser = new HashSet<HospitalEmpleadoUser>();
            Receta = new HashSet<Receta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoDocId { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public virtual TipoDocumento TipoDoc { get; set; }
        public virtual ICollection<EmpleadoEspecialidad> EmpleadoEspecialidad { get; set; }
        public virtual ICollection<EmpleadoHistorial1> EmpleadoHistorial1 { get; set; }
        public virtual ICollection<HospitalEmpleadoUser> HospitalEmpleadoUser { get; set; }
        public virtual ICollection<Receta> Receta { get; set; }
    }
}
