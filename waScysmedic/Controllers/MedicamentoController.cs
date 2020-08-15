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
        [Route("")]
        public async Task<IActionResult> ListByFarmacia(int farmaciaId)
        {
            var list = this.Context.Medicamento.
            return Ok();
        }
    }
}