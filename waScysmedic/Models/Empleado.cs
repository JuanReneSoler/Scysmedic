using System;

namespace waScysmedic.Models {
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacido { get; set; }
        public string Sexo { get; set; }
        public string DocId { get; set; }
        public int TipoDocId { get; set; }
        public int EmpresaId { get; set; }
        public int CargoId { get; set; }
        public string Mail { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}