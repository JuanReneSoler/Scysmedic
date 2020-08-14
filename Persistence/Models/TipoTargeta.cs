using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class TipoTargeta
    {
        public TipoTargeta()
        {
            TargetaVinculadas = new HashSet<TargetaVinculadas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TargetaVinculadas> TargetaVinculadas { get; set; }
    }
}
