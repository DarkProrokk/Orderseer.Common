using Orderseer.Common.Entities;

namespace Orderseer.Common.Models;

public record OrderStatusChangeModel(Guid OrderGuid, OrderStatus NewStatus);