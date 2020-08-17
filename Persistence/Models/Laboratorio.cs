using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Laboratorio
    {
        public Laboratorio()
        {
            LaboratorioEmpleadoHistorial = new HashSet<LaboratorioEmpleadoHistorial>();
            LaboratorioUser = new HashSet<LaboratorioUser>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoEmpresaId { get; set; }
        public string Direccion { get; set; }
        public string UbicacionLatitud { get; set; }
        public string UbicacionLongitud { get; set; }

        public virtual TipoEmpresa TipoEmpresa { get; set; }
        public virtual ICollection<LaboratorioEmpleadoHistorial> LaboratorioEmpleadoHistorial { get; set; }
        public virtual ICollection<LaboratorioUser> LaboratorioUser { get; set; }
    }
}
