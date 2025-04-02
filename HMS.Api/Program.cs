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

var builder = WebApplication.CreateBuilder(args);

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

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
