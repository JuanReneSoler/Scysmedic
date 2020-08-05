using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Suplidor
    {
        public Suplidor()
        {
            MedicamentoHostorial = new HashSet<MedicamentoHostorial>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoEmpresaId { get; set; }
        public string Direccion { get; set; }
        public string UbicacionLatitud { get; set; }
        public string UbicacionLongitud { get; set; }
        public DateTime FechaInicio { get; set; }

        public virtual TipoEmpresa TipoEmpresa { get; set; }
        public virtual ICollection<MedicamentoHostorial> MedicamentoHostorial { get; set; }
    }
}
