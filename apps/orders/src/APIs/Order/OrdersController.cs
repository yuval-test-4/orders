using Microsoft.AspNetCore.Mvc;

namespace Orders_1.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
