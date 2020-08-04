using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class HospitalUser
    {
        public HospitalUser()
        {
            Citas = new HashSet<Citas>();
            HospitalEmpleadoUser = new HashSet<HospitalEmpleadoUser>();
        }

        public int Id { get; set; }
        public int HospitalId { get; set; }
        public string UserId { get; set; }
        public DateTime FechaAfiliacion { get; set; }

        public virtual Hospital Hospital { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<Citas> Citas { get; set; }
        public virtual ICollection<HospitalEmpleadoUser> HospitalEmpleadoUser { get; set; }
    }
}
