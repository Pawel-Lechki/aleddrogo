namespace Aleddrogo.Server.Models;

public class Person
{
    public Guid UserId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Phone { get; set; }
    public int AddressId { get; set; }
    
    public PersonAddress Address { get; set; }
}