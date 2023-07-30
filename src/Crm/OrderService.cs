using Crm;

public sealed class OrderService
{
    public Order CreateOrder(OrderInfo orderInfo)
    {
        return new()
        {
            Name = orderInfo.Name,
            Color = orderInfo.Color,
            ID = orderInfo.ID,
            Price = orderInfo.Price
        };
    }   
}