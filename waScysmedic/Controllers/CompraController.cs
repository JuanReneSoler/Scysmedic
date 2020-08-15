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
    public class CompraController:ControllerBase
    {
        private readonly ScysmedicDbContext Context;

        public CompraController(ScysmedicDbContext context)
        {
            this.Context = context;
        }

        [HttpGet]
        [Route("api/Farmacy/GetCompras")]
        public async Task<IActionResult> List(int farmacyId, string search)
        {
            var list = this.Context.Compra.Where(x=>x.FarmaciaId == farmacyId)
                    .Select(x=>new ComprasList {
                        FechaCompra = x.FechaCompra,
                        NombreCompleto = "",
                        UserId = x.UserId
                    });

            var model = await list.ToListAsync().ConfigureAwait(false);

            model.ForEach(x=>{
                var empleado = this.Context.FarmaciaEmpleado.FirstOrDefault(y=>y.UserId == x.UserId);
                x.NombreCompleto = empleado.Nombre + " " + empleado.Apellido; 
            });

            if(!string.IsNullOrEmpty(search) && !string.IsNullOrWhiteSpace(search))
                model = model
                    .Where(x=>
                        x.NombreCompleto.Contains(search) 
                        || x.FechaCompra.ToString("dd/MM/yyyy").Contains(search))
                    .ToList();

            return Ok(model);
        }

        [HttpGet]
        [Route("api/Farmacy/Detalle")]
        public async Task<IActionResult> Detalle(int compraId)
        {
            var list = this.Context.CompraDetalle.Where(x=>x.CompraId == compraId);
            return Ok();
        }
    }
}