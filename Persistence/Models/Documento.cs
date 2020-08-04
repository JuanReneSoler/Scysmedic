using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Documento
    {
        public Documento()
        {
            Resultado = new HashSet<Resultado>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Formato { get; set; }
        public string Path { get; set; }
        public DateTime FechaCarga { get; set; }

        public virtual ICollection<Resultado> Resultado { get; set; }
    }
}
