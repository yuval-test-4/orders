using Microsoft.AspNetCore.Mvc;
using Orders_1.APIs.Common;
using Orders_1.Infrastructure.Models;

namespace Orders_1.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindManyArgs : FindManyInput<Customer, CustomerWhereInput> { }
