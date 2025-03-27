namespace Orderseer.Common.Entities;

public class Order
{
    public Guid OrderId { get; set; }
    
    public OrderStatus Status { get; set; }
    
    public PaymentInfo PaymentInfo { get; set; }
    
    public ItemsInfo ItemsInfo { get; set; }
    
    public DeliveryInfo DeliveryInfo { get; set; }
}