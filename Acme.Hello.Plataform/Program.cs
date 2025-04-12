using Acme.Hello.Plataform.Generic.Domain.Model.Entities;
using Acme.Hello.Plataform.Generic.Interfaces.Rest.Assemblers;
using Acme.Hello.Plataform.Generic.Interfaces.Rest.Resources;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
/// <summary>
/// This endpoint is responsible for greeting a developer.
/// A developer is identified by their first and last name.
/// Creates a new developer if the first and last name are provided.
/// </summary>
/// 
app.MapGet("/greetings", (string? firstName, string? lastName) =>
{
    var developer = !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName)
        ? new Developer(firstName, lastName)
        : null;
    var response = GreetDeveloperResponseAssembler.ToResponseFromEntity(developer);
    return Results.Ok(response);
}).WithName("Greetings").WithOpenApi();

app.MapPost("/greetings", (GreetDeveloperRequest request) =>
{
    var developer = DeveloperAssembler.ToEntityFromRequest(request);
    var response = GreetDeveloperResponseAssembler.ToResponseFromEntity(developer);
    return Results.Created("/greetings", response);
    
}).WithName("Greetings").WithOpenApi();


app.Run();
