# Junio19MVCEF

## Como clonar

En una ventana CMD, ir a alguna carpeta y ejecutar lo siguiente

> git clone https://github.com/escuelainformatica/Junio19MVCEF.git

## boilerplate

A un codigo que usualmente es copiar y pegar.

## tecnologias usadas.

* [x] asp.net core
* [x] asp.net core MVC 
* [ ] entity framework core <--- no aun

## Configurar asp.net core MVC

En el archivo **statup.cs**, agregar lo siguiente:

En la función **ConfigureServices**, agregar la siguiente línea.

```c#
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews(); // <-- usar MVC
    }
```
En la función Configure, indicar como se va a llamar el controlador

```c#
		// este es el enrutador.
		app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
```
