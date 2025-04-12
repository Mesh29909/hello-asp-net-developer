using Acme.Hello.Plataform.Generic.Domain.Model.Entities;
using Acme.Hello.Plataform.Generic.Interfaces.Rest.Resources;

namespace Acme.Hello.Plataform.Generic.Interfaces.Rest.Assemblers;
/// <summary>
/// This class is responsible for assembling the response for the GreetDeveloper endpoint.
/// </summary>
public class GreetDeveloperResponseAssembler
{
    /// <summary>
    /// This method converts a Developer entity to a GreetDeveloperResponse.
    /// </summary>
    /// <param name="developer">The Developer entity to convert</param>
    /// <returns>A GreetDeveloperResponse object.</returns>
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? developer)
    {
        if (developer == null || developer.IsAnyNameEmpty())
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET Developer");
        return new GreetDeveloperResponse(developer.Id, developer.GetFullName(), $"Welcome {developer.GetFullName()} You are an ASP.NET Developer");
    }
}