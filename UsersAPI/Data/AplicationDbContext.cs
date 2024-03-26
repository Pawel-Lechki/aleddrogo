using Microsoft.EntityFrameworkCore;
using UsersAPI.Models;

namespace UsersAPI.Data;

public class AplicationDbContext : DbContext
{
    public AplicationDbContext(DbContextOptions options): base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
}