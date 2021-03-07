using Microsoft.AspNetCore.Http;
using System;

namespace waScysmedic.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int TipoId { get; set; }
        public IFormFile Foto { get; set; }
        public int SuplidorId { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public int CantidadAdquirida { get; set; }
        public int PrecioCompra { get; set; }
    }
}