using Orderseer.Common.Entities;
using Orderseer.Common.Models.Dto;

namespace Orderseer.Common.Extensions;

public static class OrderMapper
{
    public static CreateOrderDto ToCreateOrderDto(this Order order)
    {
        return new CreateOrderDto
        {
            UserReference = order.UserId
        };
    }

    public static DeliveryDto ToDeliveryDto(this Order order)
    {
        return new DeliveryDto
        {
            OrderId = order.OrderId,
            DeliveryInfo = order.DeliveryInfo
        };
    }

    public static ReserveInventoryDto ToReserveInventoryDto(this Order order)
    {
        return new ReserveInventoryDto
        {
            OrderId = order.OrderId,
            ItemsInfo = order.ItemsInfo
        };
    }

    public static ProcessPaymentDto ToProcessPaymentDto(this Order order)
    {
        return new ProcessPaymentDto
        {
            OrderId = order.OrderId,
            PaymentInfo = order.PaymentInfo
        };
    }
}