using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class TipoEmpresa
    {
        public TipoEmpresa()
        {
            Hospital = new HashSet<Hospital>();
            Laboratorio = new HashSet<Laboratorio>();
            Suplidor = new HashSet<Suplidor>();
        }

        public int Id { get; set; }
        public string Siglas { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Hospital> Hospital { get; set; }
        public virtual ICollection<Laboratorio> Laboratorio { get; set; }
        public virtual ICollection<Suplidor> Suplidor { get; set; }
    }
}
