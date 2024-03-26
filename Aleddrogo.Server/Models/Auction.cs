namespace Aleddrogo.Server.Models;

public class Auction
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Guid ItemId { get; set; }
    public List<Bid> Bids { get; set; }
    
    public AuctionItem Items { get; set; }
    
}