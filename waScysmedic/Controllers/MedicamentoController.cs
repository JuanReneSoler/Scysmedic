using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using Models.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
//using Core;
using Microsoft.AspNetCore.Http;
//using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using waScysmedic.Models;
using Persistence;
using Persistence.Models;
using System;

namespace waScysmedic.Controllers
{
    [ApiController]
    [Authorize]
    //[Route("api/Account")]
    public class MedicamentoController:ControllerBase
    {
        private readonly ScysmedicDbContext Context;

        public MedicamentoController(ScysmedicDbContext context)
        {
            this.Context = context;
        }

        [HttpGet]
        [Route("api/Medicamentos/List")]
        public async Task<IActionResult> ListByFarmacia(int farmaciaId)
        {
            var list = await this.Context.Medicamento.Where(x=>x.FarmaciaId == farmaciaId)
                        .Select(x=>new ProductoList{
                            Nombre = x.Nombre,
                            Tipo = x.TipoMedicamento.Descripcion,
                            Cantidad = x.MedicamentoHostorial.Last().CantidadActual,
                            Precio = x.MedicamentoHostorial.Last().PrecioVenta,
                            FotoBase64 = x.FotoNavigation.Path
                        })
                        .ToListAsync()
                        .ConfigureAwait(false);
            return Ok();
        }

        [HttpGet]
        [Route("api/Medicamento/New")]
        public async Task<IActionResult> New()
        {
            var suplidores = this.Context.Suplidor.Select(x=>new{
                x.Id,
                x.Direccion
            });
            var tiposMedicamentos = this.Context.TipoMedicamento.Select(x=>new{
                x.Id,
                x.Descripcion
            });
            var prodcuto = new Producto
            {
                FechaCompra = DateTime.Now,
            };
            var json = new {
                prodcuto,
                suplidores,
                tiposMedicamentos
            };
            return Ok(json);
        }

        public async Task<IActionResult> New(int farmaciaId, Producto producto)
        {
            await this.Context.Medicamento.AddAsync(new Medicamento
            {
                Descripcion = producto.Descripcion,
                FarmaciaId = farmaciaId,
                FotoNavigation = new Documento
                {
                    FechaCarga = DateTime.Now,
                    Formato = string.Empty,
                    Nombre = producto.Foto.Name,
                    Path = producto.Foto.FileName,
                },
                Id = producto.Id,
                Nombre = producto.Nombre,
                MedicamentoHostorial = new List<MedicamentoHostorial>
                {
                    new MedicamentoHostorial
                    {
                        SuplidorId = producto.SuplidorId,
                        CantidadActual = 0,
                        CantidadAdquirida = producto.CantidadAdquirida,
                        Id = 0,
                        FechaCompra = producto.FechaCompra,
                        FechaVencimiento = producto.FechaVencimiento.Value,
                        PrecioCompra = producto.PrecioCompra,
                        PrecioVenta = 0,
                        Itebis = 18
                    }
                },
                TipoMedicamentoId = producto.TipoId
            }).ConfigureAwait(false);
            return Ok();
        }

        [HttpGet]
        [Route("api/Medicamento/Detalle")]
        public async Task<IActionResult> Detalle(int medicamentoId, int farmaciaId)
        {
            var entity = await this.Context.Medicamento
                    .FirstOrDefaultAsync(x=>
                        x.FarmaciaId == farmaciaId 
                        && x.Id == medicamentoId)
                        .ConfigureAwait(false);
            var producto = new Producto
            {
                CantidadAdquirida = 0,
                Descripcion = "",
                FechaCompra = DateTime.Now,
                FechaVencimiento = DateTime.Now,
                Foto = default,
                Id = 0,
                Nombre = "",
                PrecioCompra = 0,
                SuplidorId = 0,
                TipoId = 0,
            };
            return  Ok();
        }
    }
}