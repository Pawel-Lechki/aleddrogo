using Aleddrogo.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Aleddrogo.Server.Data;

public class AplicationDbContext : DbContext
{
    public AplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Auction> Auctions { get; set; }
    public DbSet<AuctionItem> AuctionItems { get; set; }
    public DbSet<Bid> Bids { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<PersonAddress> PersonAddresses { get; set; }
}