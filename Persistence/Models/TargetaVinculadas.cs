using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class TargetaVinculadas
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Numero { get; set; }
        public int BancoId { get; set; }
        public int TipoTargetaId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Banco Banco { get; set; }
        public virtual TipoTargeta TipoTargeta { get; set; }
    }
}
