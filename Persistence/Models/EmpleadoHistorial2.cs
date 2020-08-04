using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class EmpleadoHistorial2
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int CargoId { get; set; }
        public int LaboratorioId { get; set; }

        public virtual Cargo2 Cargo { get; set; }
        public virtual Empleado2 Empleado { get; set; }
        public virtual Laboratorio Laboratorio { get; set; }
    }
}
