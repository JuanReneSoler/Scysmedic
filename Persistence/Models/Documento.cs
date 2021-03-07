using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Documento
    {
        public Documento()
        {
            Medicamento = new HashSet<Medicamento>();
            Resultado = new HashSet<Resultado>();
            SeguroHistorial = new HashSet<SeguroHistorial>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Formato { get; set; }
        public string Path { get; set; }
        public DateTime FechaCarga { get; set; }

        public virtual ICollection<Medicamento> Medicamento { get; set; }
        public virtual ICollection<Resultado> Resultado { get; set; }
        public virtual ICollection<SeguroHistorial> SeguroHistorial { get; set; }
    }
}
