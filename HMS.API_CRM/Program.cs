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
using HMS.API_CRM;
using HMS.API_COMMON;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureCommonServices();


builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "FrontOffice API", Version = "v1" });
    c.DocumentFilter<CRMSwaggerDocumentFilter>();
});

var app = builder.Build();

app.ConfigureCommonMiddlewares("CRM API V1");

app.Run();