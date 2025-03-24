using Entities;

namespace Messages;

public class OrderStatusChangedEvent
{
    public Guid OrderId { get; set; }
    
    public required Status Status { get; set; }
}

public class Status
{
    public OrderStatus Code { get; set; } 
    public string Name { get; set; }
}