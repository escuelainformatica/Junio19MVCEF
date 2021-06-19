using Junio19MVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junio19MVCEF.repo
{
    // OOP
    // SRP.

    // ParteRepo, ParteDAO (Data Access Objet), ParteBase...

    // Clase de servicio.
    // esta clase de servicio tiene todas las funciones de la base de datos.
    public class ParteRepo
    {
        public static List<Parte> ListarTodo()
        {
            // conectar a la base de datos
            var contexto=new BasePartesContext(); // <-- entity framework
            // leer la informacion
            List<Parte> listado=contexto
                .Partes
                .OrderBy( p => p.Nombre) // <--- LINQ (operacion lambda)
                .ToList(); // <-- LINQ que usa entity framework.
            // desconectar de la base de datos.
            contexto.Dispose();
            // devuelvo los valores
            return listado;
        }
    }
}
