using GraphQlExample.Controllers;
using GraphQlExample.Mutations;
using GraphQlExample.Queries;
using GraphQlExample.Repositories;
using GraphQlExample.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

// query, mutations, subscriptions 

builder.Services.AddScoped<IRepository, Repository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.MapControllers();

app.Run();
