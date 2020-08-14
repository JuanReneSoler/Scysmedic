using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Banco
    {
        public Banco()
        {
            TargetaVinculadas = new HashSet<TargetaVinculadas>();
        }

        public int Id { get; set; }
        public string Siglas { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Rnc { get; set; }
        public DateTime Fecha { get; set; }

        public virtual ICollection<TargetaVinculadas> TargetaVinculadas { get; set; }
    }
}
