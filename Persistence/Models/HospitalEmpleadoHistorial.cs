using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class HospitalEmpleadoHistorial
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int CargoId { get; set; }
        public int LaboratorioId { get; set; }

        public virtual HospitalCargo Cargo { get; set; }
        public virtual HospitalEmpleado Empleado { get; set; }
        public virtual Hospital Laboratorio { get; set; }
    }
}
