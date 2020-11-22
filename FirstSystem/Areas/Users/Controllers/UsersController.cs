using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstSystem.Areas.Users.Controllers
{
    [Area("Users")]
    public class UsersController : Controller
    {
        /// <summary>
        /// Este es el metodo de accion que se va a ejecutar
        /// </summary>
        /// <returns></returns>
        public IActionResult Users()
        {
            return View();
        }
    }
}
