using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class FarmaciaEmpleadoHistorial
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int CargoId { get; set; }
        public int FarmaciaId { get; set; }

        public virtual FarmaciaCargo Cargo { get; set; }
        public virtual FarmaciaEmpleado Empleado { get; set; }
        public virtual Farmacia Farmacia { get; set; }
    }
}
