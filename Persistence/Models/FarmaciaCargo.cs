using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class FarmaciaCargo
    {
        public FarmaciaCargo()
        {
            FarmaciaEmpleadoHistorial = new HashSet<FarmaciaEmpleadoHistorial>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<FarmaciaEmpleadoHistorial> FarmaciaEmpleadoHistorial { get; set; }
    }
}
