using HMS.API_COMMON;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureCommonServices();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>() // Query s?n?f? GraphQL sorgular?n?z? tan?mlar.
                           //.AddMutationType<Mutation>() // Mutation s?n?f? iste?e ba?l?d?r.
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

app.ConfigureCommonMiddlewares(null);

app.Run();
