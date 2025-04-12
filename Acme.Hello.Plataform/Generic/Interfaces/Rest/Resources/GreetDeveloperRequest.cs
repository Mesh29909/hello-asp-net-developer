namespace Acme.Hello.Plataform.Generic.Interfaces.Rest.Resources;
/// <summary>
/// This class represents a request to greet a developer.
/// Contains properties for the developer's first and last name.
/// </summary>
/// <param name="FirstName">The first name of the developer</param>
/// <param name="LastName">The last name of the developer</param>
public record GreetDeveloperRequest(string? FirstName, string? LastName);