using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class LaboratorioCargo
    {
        public LaboratorioCargo()
        {
            LaboratorioEmpleadoHistorial = new HashSet<LaboratorioEmpleadoHistorial>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<LaboratorioEmpleadoHistorial> LaboratorioEmpleadoHistorial { get; set; }
    }
}
