using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class HospitalCargo
    {
        public HospitalCargo()
        {
            HospitalEmpleadoHistorial = new HashSet<HospitalEmpleadoHistorial>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<HospitalEmpleadoHistorial> HospitalEmpleadoHistorial { get; set; }
    }
}
