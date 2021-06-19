using Junio19MVCEF.Models;
using Junio19MVCEF.repo;
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
            // crear la vista: boton derecho en la vista
            // -> crear vista.
            // --> la vista tiene que tener el mismo nombre que el metodo.
            return View();
        }

        // http://localhost:45374/Parte/Tabla


        public IActionResult Tabla()
        {
            List<Parte> partes=ParteRepo.ListarTodo();

            ViewBag.partes=partes;
            ViewData["partes"]=partes;
            // Modelo

            return View();
        }
    }
}
