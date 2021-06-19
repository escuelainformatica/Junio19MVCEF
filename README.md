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
## Agregar Entity Framework Core

Con Nuget (Package Manager Console)

```
Install-Package Microsoft.EntityFrameworkCore -Version 6.0.0-preview.5.21301.9
Install-Package Microsoft.EntityFrameworkCore.Relational -Version 6.0.0-preview.5.21301.9
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.0-preview.5.21301.9
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.0-preview.5.21301.9
```

## Scaffold

Usando el Package Manager Console, cambiando lo siguiente:

* Data Source : La instancia donde esta la base de datos
* Initial Catalog: Nuestra base de datos
* Microsoft.EntityFrameworkCore.SqlServer : Si vamos a usar sql server
* -OutputDir Models : la carpeta que se va a generar

```
Scaffold-DbContext "Data Source=(local)\SQLEXPRESS;Initial Catalog=BasePartes;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models 
```

Puede usarse

* -force : sobreescribe el codigo ya generado
* -dataannotations: Use las anotaciones en vez de agregar la definicion en la clase de contexto

