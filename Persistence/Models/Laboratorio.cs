using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Laboratorio
    {
        public Laboratorio()
        {
            EmpleadoHistorial2 = new HashSet<EmpleadoHistorial2>();
            LaboratorioUser = new HashSet<LaboratorioUser>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoEmpresaId { get; set; }
        public string Direccion { get; set; }
        public string UbicacionLatitud { get; set; }
        public string UbicacionLongitud { get; set; }

        public virtual TipoEmpresa TipoEmpresa { get; set; }
        public virtual ICollection<EmpleadoHistorial2> EmpleadoHistorial2 { get; set; }
        public virtual ICollection<LaboratorioUser> LaboratorioUser { get; set; }
    }
}
