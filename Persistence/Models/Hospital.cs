using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Hospital
    {
        public Hospital()
        {
            EmpleadoHistorial1 = new HashSet<EmpleadoHistorial1>();
            HospitalUser = new HashSet<HospitalUser>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoEmpresaId { get; set; }
        public string Direccion { get; set; }
        public int UbicacionLongitud { get; set; }
        public int UbicacionLatitud { get; set; }

        public virtual TipoEmpresa TipoEmpresa { get; set; }
        public virtual ICollection<EmpleadoHistorial1> EmpleadoHistorial1 { get; set; }
        public virtual ICollection<HospitalUser> HospitalUser { get; set; }
    }
}
