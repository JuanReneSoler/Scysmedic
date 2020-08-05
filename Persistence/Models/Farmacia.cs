using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Farmacia
    {
        public Farmacia()
        {
            EmpleadoHistorial = new HashSet<EmpleadoHistorial>();
            FarmaciaUser = new HashSet<FarmaciaUser>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoEmpresaId { get; set; }

        public virtual ICollection<EmpleadoHistorial> EmpleadoHistorial { get; set; }
        public virtual ICollection<FarmaciaUser> FarmaciaUser { get; set; }
    }
}
