using Orderseer.Common.Entities;

namespace Orderseer.Common.Models.Dto;

public class DeliveryDto: OrderDtoBase
{
    public DeliveryInfo DeliveryInfo { get; set; }
}