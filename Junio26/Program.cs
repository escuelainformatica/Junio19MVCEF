
using Junio26.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Junio26
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENTITY FRAMEWORK (CORE) ENTITY FRAMEWORK (NET FRAMEWORK).


            var contexto=new sakilaContext();
            // listar la tabla actor.
            var actores=contexto.Actors.ToList();
            // listar filtrado
            var actores2=contexto // <-- base de datos sakila
                .Actors // <-- tabla actor y el modelo Actor (lista de actores)
                .Where( actor => actor.FirstName=="KEVIN") //  => operacion lambda  alias => (donde) ....
                .ToList();

            var ciudades=contexto
                .Cities // <-- ciudades 
                .Include( c => c.Country) // <-- que incluya dentro de cada ciudad el pais
                .ToList(); // <-- lista de ciudades (que incluye el pais)



            var numeros=new int[] {2,3,4,5};
            var filtro=numeros // lista de numeros
                .Where( n => n>3) // filtrar los numeros, donde el numero tiene que ser mayor a 3
                .ToList(); // devolver como un listado de numeros.



            Console.WriteLine("Hello World!");


        }
    }
}
