using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Farmacia
    {
        public Farmacia()
        {
            FarmaciaEmpleadoHistorial = new HashSet<FarmaciaEmpleadoHistorial>();
            FarmaciaUser = new HashSet<FarmaciaUser>();
            Medicamento = new HashSet<Medicamento>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoEmpresaId { get; set; }

        public virtual ICollection<FarmaciaEmpleadoHistorial> FarmaciaEmpleadoHistorial { get; set; }
        public virtual ICollection<FarmaciaUser> FarmaciaUser { get; set; }
        public virtual ICollection<Medicamento> Medicamento { get; set; }
    }
}
