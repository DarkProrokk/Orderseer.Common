using Orderseer.Common.Entities;

namespace Orderseer.Common.Models.Dto;

public class ReserveInventoryDto: OrderDtoBase
{
    public ItemsInfo ItemsInfo { get; set; }
}