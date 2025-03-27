namespace Orderseer.Common.Entities;

public class Item
{
    public Guid ItemId { get; set; }
    
    public int Amount { get; set; }
    
    public decimal Price { get; set; }
}