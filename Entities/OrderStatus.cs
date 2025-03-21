﻿namespace Orderseer.Common.Entities;

public enum OrderStatus
{
    Pending = 1, //Заказ создан, информация о нём зарегистрирован
    Processing, //Заказ обработан. Т.е. проверенно наличие и тд. //todo Имитировать процесс обработки заказа 
    Shipped, //Заказ отправлен. Т.е. отгружен продавцом //todo Имитировать процесс отправки заказа
    Delivered, //Заказ доставлен.
    Cancelled, //Заказ отменён.
    Returned //Заказ возвращён. Специальный статус, который не показывается пользователю. Имеется вви
}