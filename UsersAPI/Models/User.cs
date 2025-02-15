﻿namespace UsersAPI.Models;

public class User
{
    public Guid UserId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Phone { get; set; }
    public int AddressId { get; set; }
    
    public Address Address { get; set; }
}