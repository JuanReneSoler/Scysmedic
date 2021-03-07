using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Resultado
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int LaboratorioId { get; set; }
        public int DocumentoId { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Documento Documento { get; set; }
        public virtual LaboratorioUser Laboratorio { get; set; }
    }
}
