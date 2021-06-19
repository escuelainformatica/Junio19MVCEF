using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junio19MVCEF.controlador
{
    // 1) Tiene que terminar con el nombre Controller (no Controller1)
    // 2) Tiene que heredar la clase Controller
    // 3) Tiene que tener metodos que regresan un IActionResult

    public class ParteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        // http://localhost:45374/Parte/Ejemplo
        public IActionResult Ejemplo()
        {

            return View();
        }
    }
}
