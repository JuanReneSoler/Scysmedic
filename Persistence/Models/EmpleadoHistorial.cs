using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class EmpleadoHistorial
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int CargoId { get; set; }
        public int FarmaciaId { get; set; }

        public virtual Cargo Cargo { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Farmacia Farmacia { get; set; }
    }
}
