namespace Acme.Hello.Plataform.Generic.Domain.Model.Entities;

public class Developer
{
    /// <summary>
    /// Creates a unique identifier for the developer.
    /// </summary>
    public Guid Id { get; }  = Guid.NewGuid();
    /// <summary>
    /// Creates a first name for the developer.
    /// </summary>
    public string FirstName { get; }
    /// <summary>
    /// Creates a last name for the developer.
    /// </summary>
    public string LastName { get; }
 /// <summary>
 /// Initializes a new instance of the <see cref="Developer"/> class with the specified first and last name.
 /// </summary>
 /// <remarks>
 /// The constructor initializes the FirstName and LastName properties with the provided values.
 /// </remarks>
 /// <param name="firstName"> The first name of the developer</param>
 /// <param name="lastName">The last name of the developer</param>
    public Developer(string firstName, string lastName)
    {
        FirstName = string.IsNullOrWhiteSpace(firstName) ? "": firstName.Trim();
        LastName = string.IsNullOrWhiteSpace(lastName) ? "": lastName.Trim();
    }
 /// <summary>
 /// Gets the full name of the developer by concatenating the first and last name.
 /// </summary>
 /// <returns>true if either the first name or last name is empty or consists only of whitespaces </returns>
    public string GetFullName()
    {
        return $"{FirstName} {LastName}".Trim();
    }
 /// <summary>
 ///  Checks if either the first name or last name is empty or consists only of whitespaces.
 /// </summary>
 /// <returns>
 ///true if either the first name or last name is empty or consists only of whitespaces; otherwise, false.
 /// </returns>
 
    public bool IsAnyNameEmpty()
    {
        return string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName);
    }
}