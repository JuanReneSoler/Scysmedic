using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class EmpleadoHistorial1
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int CargoId { get; set; }
        public int LaboratorioId { get; set; }

        public virtual Cargo1 Cargo { get; set; }
        public virtual Empleado1 Empleado { get; set; }
        public virtual Hospital Laboratorio { get; set; }
    }
}
