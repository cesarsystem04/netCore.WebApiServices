using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using WebApiServices.Context;
using MediatR;


namespace WebApiServices.Extensiones
{
    internal static class ServiceCollectionExtensions
    {
        internal static IServiceCollection AddDatabase(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddDbContext<UoWKernelContext>(options => options
                    .UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


        internal static void ApiVersioning(this IServiceCollection services)
        {
            //Soportar el versionamiento de la API
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0); // Versión por default
                config.AssumeDefaultVersionWhenUnspecified = true; // En caso de que no se especifique usar versión por default
                config.ReportApiVersions = true; // Soporte para repotar API como Deprecated
            });

            //Generar la versión de la API en la documentación
            services.AddVersionedApiExplorer(o =>
            {
                o.GroupNameFormat = "'v'VVV";
                o.SubstituteApiVersionInUrl = true; //Sustituir la versión de la API en la URL de la documentación
            });
        }


        internal static void RegisterSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                // Incluir todos los comentarios xml del proyecto
                var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    if (!assembly.IsDynamic)
                    {
                        var xmlFile = $"{assembly.GetName().Name}.xml";
                        var xmlPath = System.IO.Path.Combine(baseDirectory, xmlFile);
                        if (System.IO.File.Exists(xmlPath))
                        {
                            c.IncludeXmlComments(xmlPath);
                        }
                    }
                }

                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "CartaPorte.API.V1",
                    License = new OpenApiLicense
                    {
                        Name = $"Condumex S.A. de C.V. @ {DateTime.Now.Year}",
                        Url = new Uri("https://cartaporte.condumex.com.mx")
                    },
                    Contact = new OpenApiContact
                    {
                        Name = "Julio Cesar Cuautle",
                        Email = "jcuautle@condumex.com.mx"
                    }
                });
            });
        }



        internal static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //services.AddTransient<IDescargaMasivaSAT, DescargaMasivaSAT>();
            //services.AddTransient<EdxSettings>();
            //services.AddTransient<IProveedorTimbrado, ProveedorTimbradoEdx>();
            //services.AddTransient<FtpOracleSettings, FtpOracleSettings>();
            //services.AddTransient<IFtpOperationsCdxInc, FtpServerCdxInc>();
            //services.AddTransient<IImportacionesOperations, ImportacionesOperations>();
            //services.AddTransient<IExceptionLogControl, ExceptionLogControl>();
            //services.AddTransient<IFtpServerInB2b, FtpServerInB2b>();
            //services.AddTransient<IFtpServerInTralix, FtpServerInTralix>();
            //services.AddTransient<IFtpServerOutB2b, FtpServerOutB2b>();
            //services.AddTransient<IFtpServerOutTralix, FtpServerOutTralix>();
            //services.AddTransient<IFtpServerLogtec, FtpServerLogtec>();
            //services.AddTransient<IXmlProcesarArchivo, XmlProcesarArchivo>();
            //services.AddTransient<IProcesarCadena, ProcesarCadena>();
            //services.AddTransient<IDescargaArchivosCfdiB2b, DescargaArchivosCfdiB2b>();
            //services.AddTransient<IDescargaArchivosCfdiTralix, DescargaArchivosCfdiTralix>();
            //services.AddTransient<FtpB2bSettings>();
            //services.AddTransient<FtpB2bBackupSettings>();
            //services.AddTransient<FtpTralixSettings>();
            //services.AddTransient<FtpTralixBackupSettings>();
            //services.AddTransient<FtpLogtecSettings>();
            //services.AddTransient<ApiB2bCfdiSettings>();
            //services.AddTransient<ApiTralixCfdiSettings>();
            return services;
        }
    }





}
