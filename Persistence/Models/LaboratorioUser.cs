using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class LaboratorioUser
    {
        public LaboratorioUser()
        {
            Resultado = new HashSet<Resultado>();
        }

        public int Id { get; set; }
        public int LaboratorioId { get; set; }
        public string UserId { get; set; }
        public DateTime FechaAfiliacion { get; set; }

        public virtual Laboratorio Laboratorio { get; set; }
        public virtual ICollection<Resultado> Resultado { get; set; }
    }
}
