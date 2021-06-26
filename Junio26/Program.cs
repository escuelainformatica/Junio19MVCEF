
using Junio26.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            /* select *
            	from city
	                inner join country on city.country_id=country.country_id
            */
            List<City> ciudades=contexto
                .Cities // <-- ciudades 
                .Include( c => c.Country) // <-- que incluya dentro de cada ciudad el pais
                .Where( c => c.Country.Country1=="Chile") 
                .ToList(); // <-- lista de ciudades (que incluye el pais)


            List<Country> paises = contexto
                .Countries // <-- paises 
                .Include(pais => pais.Cities) // <-- incluir las ciudades por cada pais
                .ToList(); // <-- lista de paises




            var numeros=new int[] {2,3,4,5};
            var filtro=numeros // lista de numeros
                .Where( n => n>3) // filtrar los numeros, donde el numero tiene que ser mayor a 3
                .ToList(); // devolver como un listado de numeros.



            Console.WriteLine("Hello World!");


        }
    }
}
