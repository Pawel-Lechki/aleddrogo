namespace Aleddrogo.Server.Models;

public class AuctionItem
{
    public Guid ItemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal StartingPrice { get; set; }
    public decimal CurrentPrice { get; set; }
    public Guid ActionId { get; set; }
}