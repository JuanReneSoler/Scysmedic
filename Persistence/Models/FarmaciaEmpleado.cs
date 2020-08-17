using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class FarmaciaEmpleado
    {
        public FarmaciaEmpleado()
        {
            FarmaciaEmpleadoHistorial = new HashSet<FarmaciaEmpleadoHistorial>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoDocId { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string UserId { get; set; }

        public virtual TipoDocumento TipoDoc { get; set; }
        public virtual ICollection<FarmaciaEmpleadoHistorial> FarmaciaEmpleadoHistorial { get; set; }
    }
}
