using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using HMS.Business;
using HMS.Application;
using HMS.Infrastructure.Autofac;
using HMS.Infrastructure.AutoMapper;
using MediatR;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using HMS.API_COMMON;

var builder = WebApplication.CreateBuilder(args);

///swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Common", Version = "v1" });
    c.DocumentFilter<CommonSwaggerDocumentFilter>();
});
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

var app = builder.Build();

/// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Common API V1"); // Her projenin endpoint'i deðiþebilir
        c.RoutePrefix = "swagger"; // Swagger UI'yi /swagger dizininde göstermek için
    });
}
///

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();