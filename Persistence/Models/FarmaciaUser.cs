using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class FarmaciaUser
    {
        public FarmaciaUser()
        {
            Compra = new HashSet<Compra>();
        }

        public int Id { get; set; }
        public int FarmaciaId { get; set; }
        public string UserId { get; set; }
        public DateTime FechaAfiliacion { get; set; }

        public virtual Farmacia Farmacia { get; set; }
        public virtual ICollection<Compra> Compra { get; set; }
    }
}
