using Aplicacion.Extension;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiServices.Extensiones;
using WebApiServices.Infraestructure;

namespace WebApiServices
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages(); // Agregar servicios a los controladores de las APIs

            services.ApiVersioning(); // Agregar versionamiento de la API. Ayuda en https://github.com/dotnet/aspnet-api-versioning/wiki

            services.AddDatabase(Configuration); //Agregar conexto de base de datos

            services.AddApplicationLayer(); // Configurar servicios de la capa de aplicación

            services.AddApplicationServices(); //Agregar sevicios que se ocupan en la aplicación

            services.AddRepositories(); //Agregar conexión a entidades, por medio de repositorios

            //services.AddControllers().AddValidators(); // Registrar objetos con validaciones

            services.RegisterSwagger(); //Activar generador de contenido para Swagger como JSON

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionHandling(env); // Compactar la instrucción de manejo de excepciones en ambiente dev
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(); // Compactar las instrucciones de mapeo de controladores
            //app.ConfigureSwagger(); // Configurar EndPoint con documentación de la API
            app.UseSwagger();
            app.UseSwaggerUI();
        }

    }
}
