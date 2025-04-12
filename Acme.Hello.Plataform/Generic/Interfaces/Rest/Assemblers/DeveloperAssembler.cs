
using Acme.Hello.Plataform.Generic.Domain.Model.Entities;
using Acme.Hello.Plataform.Generic.Interfaces.Rest.Resources;
using Acme.Hello.Plataform.Generic.Interfaces.Rest.Assemblers;

namespace Acme.Hello.Plataform.Generic.Interfaces.Rest.Assemblers;

public class DeveloperAssembler
{
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request == null||string.IsNullOrWhiteSpace(request.FirstName) ||
            string.IsNullOrWhiteSpace(request.LastName))
        { return null;}

        return new Developer(request.FirstName, request.LastName);
    }
}