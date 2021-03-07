using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            FarmaciaEmpleado = new HashSet<FarmaciaEmpleado>();
            HospitalEmpleado = new HashSet<HospitalEmpleado>();
            LaboratorioEmpleado = new HashSet<LaboratorioEmpleado>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<FarmaciaEmpleado> FarmaciaEmpleado { get; set; }
        public virtual ICollection<HospitalEmpleado> HospitalEmpleado { get; set; }
        public virtual ICollection<LaboratorioEmpleado> LaboratorioEmpleado { get; set; }
    }
}
