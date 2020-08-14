using System;

namespace waScysmedic.Models {
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string DocId { get; set; }
        public DateTime FechaNacido { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}