using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class HospitalEmpleado
    {
        public HospitalEmpleado()
        {
            HospitalEmpleadoEspecialidad = new HashSet<HospitalEmpleadoEspecialidad>();
            HospitalEmpleadoHistorial = new HashSet<HospitalEmpleadoHistorial>();
            HospitalEmpleadoUser = new HashSet<HospitalEmpleadoUser>();
            Receta = new HashSet<Receta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoDocId { get; set; }
        public string DocId { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public virtual TipoDocumento TipoDoc { get; set; }
        public virtual ICollection<HospitalEmpleadoEspecialidad> HospitalEmpleadoEspecialidad { get; set; }
        public virtual ICollection<HospitalEmpleadoHistorial> HospitalEmpleadoHistorial { get; set; }
        public virtual ICollection<HospitalEmpleadoUser> HospitalEmpleadoUser { get; set; }
        public virtual ICollection<Receta> Receta { get; set; }
    }
}
