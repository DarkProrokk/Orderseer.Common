using Orderseer.Common.Entities;

namespace Orderseer.Common.Models.Dto;

public class ProcessPaymentDto: OrderDtoBase
{
    public PaymentInfo PaymentInfo { get; set; }
}