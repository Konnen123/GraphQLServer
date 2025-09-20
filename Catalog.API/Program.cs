var builder = WebApplication.CreateBuilder(args);

builder.AddGraphQL().AddTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);

[QueryType]
public static class Query
{
    public static string SayHello(string name = "World") => $"Hello, {name}";
    
    public static Book GetBook() 
        => new Book("C# in Depth", new Author("Jon Skeet"));
}

public record Book(string Title, Author Author);

public record Author(string Name);