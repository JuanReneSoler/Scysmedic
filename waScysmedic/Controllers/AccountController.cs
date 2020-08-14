  
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

namespace waScysmedic.Controllers
{
    [ApiController]
    [Authorize]
    //[Route("api/Account")]
    public class AccountController:ControllerBase
    {
        private readonly UserManager<IdentityUser> UserManager;
        private readonly SignInManager<IdentityUser> SignInManager;
        private readonly ScysmedicDbContext Context;

        public AccountController(
            UserManager<IdentityUser> UserManager,
            SignInManager<IdentityUser> SigInManager,
            ScysmedicDbContext context
        )
        {
            this.UserManager = UserManager;
            this.SignInManager = SigInManager;
            this.Context = context;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/Account/LogIn")]
        public async Task<IActionResult> LogIn(LogIn log)
        {
            if(!ModelState.IsValid)
                return BadRequest("Usuario o contrasena incorrectos");

            try{
                var user = await this.UserManager.FindByNameAsync(log.userName);
                var result = await this.UserManager.CheckPasswordAsync(user, log.Password);
                
                if(!result)
                    return BadRequest("contrase~na incorrecta.");

                await this.SignInManager.SignInAsync(user, log.rememberMe, null);
                
                var entity = await this.Context.InformacionPersonal
                    .FirstOrDefaultAsync(x=>x.UserId == user.Id)
                    .ConfigureAwait(false);
                
                return Ok(entity);
            }
            catch{
                return BadRequest("Esta cuenta no existe.");
            }
        }

        [AllowAnonymous]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("api/Account/New")]
        public async Task<IActionResult> New(Usuario user)
        {
            // if(!ModelState.IsValid)
            // {
            //     foreach (var item in ModelState.er)
            //     {
            //         ModelState.AddModelError("", item.Description);
            //     }
            //     return BadRequest();
            // }

            var p = await this.UserManager.FindByNameAsync(user.User);

            var obj = new IdentityUser
            {
                UserName = user.User,
                Email = user.Mail
            };
            var result = await this.UserManager.CreateAsync(obj, user.Password);

            return result.Succeeded ? (IActionResult)Ok() : (IActionResult)BadRequest();

            if(result.Succeeded)
            {
                await this.Context.InformacionPersonal.AddAsync(new InformacionPersonal{
                    Apellido = user.Apellido,
                    DocId = user.DocId,
                    FechaNacimiento = user.FechaNacido,
                    Id = user.Id,
                    Mail = user.Mail,
                    Nombre = user.Nombre,
                    UserId = obj.Id,
                }).ConfigureAwait(false);

                await this.Context.SaveChangesAsync().ConfigureAwait(false);
                
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}