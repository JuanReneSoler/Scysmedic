  
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

namespace waScysmedic.Controllers
{

    public class LogIn{
        public string userName { get; set; }
        public string Password { get; set; }
        public bool rememberMe { get; set; }
    }

    [ApiController]
    [Authorize]
    //[Route("api/Account")]
    public class AccountController:ControllerBase
    {
        private readonly UserManager<IdentityUser> UserManager;
        private readonly SignInManager<IdentityUser> SignInManager;

        public AccountController(
            UserManager<IdentityUser> UserManager,
            SignInManager<IdentityUser> SigInManager
        )
        {
            this.UserManager = UserManager;
            this.SignInManager = SigInManager;
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
                if (result)
                {
                    await this.SignInManager.SignInAsync(user, log.rememberMe, null);
                    return RedirectToAction("StartPage", "Home");
                }
                return Ok(user);
            }
            catch{
                return BadRequest("Esta cuenta no existe.");
            }
        }

        // [AllowAnonymous]
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> New(dynamic administrador)
        // {
            // if (this.UserManager.Users.Any(x => x.UserName == administrador.UserName))
            //     ModelState.AddModelError("", "Este usuario ya existe.");
            // if(ModelState.IsValid)
            // {
            //     var user = new IdentityUser
            //     {
            //         UserName = administrador.UserName,
            //         Email = administrador.Email
            //     };
            //     var result = await this.UserManager.CreateAsync(user, administrador.Password);
            //     if(result.Succeeded)
            //     {
            //         return RedirectToAction(nameof(this.Index));
            //     }
            //     else
            //     {
            //         foreach (var item in result.Errors)
            //         {
            //             ModelState.AddModelError("", item.Description);
            //         }
            //     }
            // }

            // return View(administrador);
        //     return Ok();
        // }
    }
}