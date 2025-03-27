namespace Orderseer.Common.Entities;

public class DeliveryInfo
{
    public Guid DeliveryGuid { get; set; }
    
    public string Adress { get; set; }
    
    public DeliveryType Type { get; set; }
}