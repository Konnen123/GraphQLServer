using Catalog.Application;
using Catalog.Infrastructure;
using DotNetEnv;

Env.Load();

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();

string defaultConnectionStringPrefix = "ConnectionStrings:DefaultConnection";
var host = Environment.GetEnvironmentVariable("DB_HOST");
var port = Environment.GetEnvironmentVariable("DB_PORT");
var user = Environment.GetEnvironmentVariable("DB_USER");
var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");

string defaultConnectionString = $"Host={host};Port={port};Database={dbName};Username={user};Password={password};";
builder.Configuration.AddInMemoryCollection(new Dictionary<string, string>
{
    [defaultConnectionStringPrefix] = defaultConnectionString
}!);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();
builder.AddGraphQL().AddTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);

[QueryType]
public static class Query
{
    public static string SayHello(string name = "World") => $"Hello, {name}";
    
}
