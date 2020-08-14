using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class SeguroHistorial
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string NumeroSeguro { get; set; }
        public int SeguroId { get; set; }
        public DateTime Fecha { get; set; }
        public int DocumentoId { get; set; }

        public virtual Documento Documento { get; set; }
        public virtual Aseguradora Seguro { get; set; }
    }
}
