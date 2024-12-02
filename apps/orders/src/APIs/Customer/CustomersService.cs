using Orders_1.Infrastructure;

namespace Orders_1.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(Orders_1DbContext context)
        : base(context) { }
}
