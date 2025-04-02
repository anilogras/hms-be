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
using HMS.API_FRONTOFFICE;
using HMS.API_COMMON;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureCommonServices();


///swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "FrontOffice", Version = "v1" });
    c.DocumentFilter<FrontOfficeSwaggerDocumentFilter>();

});
///


var app = builder.Build();

app.ConfigureCommonMiddlewares("FrontOffice API V1");
app.Run();