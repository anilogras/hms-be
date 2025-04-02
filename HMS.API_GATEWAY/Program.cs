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
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Microsoft.OpenApi.Models;
using HMS.API_COMMON;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureCommonServices();

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

builder.Services.AddOcelot(builder.Configuration);


/// Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Gateway", Version = "v1" });
});
///


var app = builder.Build();
app.ConfigureCommonMiddlewares();

// Swagger'ý etkinleþtirin
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/common/swagger.json", "Common API");
        c.SwaggerEndpoint("/swagger/v1/frontoffice/swagger.json", "FrontOffice API");
        c.SwaggerEndpoint("/swagger/v1/crm/swagger.json", "CRM API");
    });
}

////ochelot 
app.UseOcelot().Wait();
///

app.Run();