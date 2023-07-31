using Crm;

public sealed class OrderService
{
    public Order CreateOrder(OrderInfo orderInfo)
    {
        return new()
        {
            Name = orderInfo.Name,
            Color = orderInfo.Color,
            Id = orderInfo.Id,
            Price = orderInfo.Price
        };
    }   
}