namespace Acme.Hello.Plataform.Generic.Interfaces.Rest.Resources;
/// <summary>
/// This class represents a response to a request to greet a developer.
/// </summary>
/// <param name="Id">The Id of the developer</param>
/// <param name="FullName">The full name of the developer</param>
/// <param name="Message">The greeting message</param>
public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    /// <summary>
    ///  This constructor initializes a new instance of the <see cref="GreetDeveloperResponse"/> class with the specified message.
    /// </summary>
    /// <param name="Message">The greeting message</param>
    public GreetDeveloperResponse(string Message): this(null, null, Message)
    {
    }
}
