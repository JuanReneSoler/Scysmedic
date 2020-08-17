using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class LaboratorioEmpleadoHistorial
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int CargoId { get; set; }
        public int LaboratorioId { get; set; }

        public virtual LaboratorioCargo Cargo { get; set; }
        public virtual LaboratorioEmpleado Empleado { get; set; }
        public virtual Laboratorio Laboratorio { get; set; }
    }
}
