using Orders_1.Infrastructure;

namespace Orders_1.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(Orders_1DbContext context)
        : base(context) { }
}
