using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Medicamento
    {
        public Medicamento()
        {
            MedicamentoHostorial = new HashSet<MedicamentoHostorial>();
            RecetaDetalle = new HashSet<RecetaDetalle>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int TipoMedicamentoId { get; set; }

        public virtual TipoMedicamento TipoMedicamento { get; set; }
        public virtual ICollection<MedicamentoHostorial> MedicamentoHostorial { get; set; }
        public virtual ICollection<RecetaDetalle> RecetaDetalle { get; set; }
    }
}
