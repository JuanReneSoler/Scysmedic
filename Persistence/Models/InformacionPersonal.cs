using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class InformacionPersonal
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DocId { get; set; }
        public string Mail { get; set; }
    }
}
