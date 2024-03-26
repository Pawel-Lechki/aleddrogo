namespace Aleddrogo.Server.Models;

public class Bid
{
    public Guid Id { get; set; }
    public int ActionItemId { get; set; }
    public Person UserId { get; set; }
    public decimal Amount { get; set; }
    public DateTime BidTime { get; set; }
    
    public Person Person { get; set; }
}

