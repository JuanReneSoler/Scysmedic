using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Empleado2
    {
        public Empleado2()
        {
            EmpleadoHistorial2 = new HashSet<EmpleadoHistorial2>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoDocId { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public virtual TipoDocumento TipoDoc { get; set; }
        public virtual ICollection<EmpleadoHistorial2> EmpleadoHistorial2 { get; set; }
    }
}
