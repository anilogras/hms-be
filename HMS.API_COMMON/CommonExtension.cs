using Autofac.Extensions.DependencyInjection;
using Autofac;
using HMS.Application;
using HMS.Infrastructure.Autofac;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.ResponseCompression;
using System.IO.Compression;

namespace HMS.API_COMMON
{
    public static class CommonExtension
    {
        public static WebApplicationBuilder ConfigureCommonServices(this WebApplicationBuilder builder) {


            ///swagger
            builder.Services.AddEndpointsApiExplorer();           
            ///

            //////MEdiarRB
            builder.Services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(typeof(MediatRConfig).Assembly);
            });
            /////MediatR
            builder.Services.AddControllers();

            ///////AUTOFAC
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

            builder.Host.ConfigureContainer<ContainerBuilder>(cb =>
            {
                cb.RegisterModule<GeneralAutofacConfig>();
            });
            ///////AUTOFAC
            ///
            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });



            //////////////compression

            builder.Services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true; 
                options.Providers.Add<GzipCompressionProvider>();
                options.Providers.Add<BrotliCompressionProvider>();
            });

            builder.Services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal; 
            });

            // Brotli ayarlarını yapılandır
            builder.Services.Configure<BrotliCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
            });

            /////

            return builder;
        }

        public static WebApplication ConfigureCommonMiddlewares(this WebApplication app , string? swaggerInstanceName = null) {

            /// Swagger
            if (!string.IsNullOrEmpty(swaggerInstanceName) && app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", swaggerInstanceName); // Her projenin endpoint'i deðiþebilir
                    c.RoutePrefix = "swagger"; // Swagger UI'yi /swagger dizininde göstermek için
                });
            }
            ///

            app.UseResponseCompression();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }
    }
}
