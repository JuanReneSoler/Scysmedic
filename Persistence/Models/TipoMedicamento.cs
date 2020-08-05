using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class TipoMedicamento
    {
        public TipoMedicamento()
        {
            Medicamento = new HashSet<Medicamento>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Medicamento> Medicamento { get; set; }
    }
}
