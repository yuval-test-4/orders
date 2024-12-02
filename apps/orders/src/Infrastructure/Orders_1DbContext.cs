using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Orders_1.Infrastructure.Models;

namespace Orders_1.Infrastructure;

public class Orders_1DbContext : IdentityDbContext<IdentityUser>
{
    public Orders_1DbContext(DbContextOptions<Orders_1DbContext> options)
        : base(options) { }

    public DbSet<CustomerDbModel> Customers { get; set; }

    public DbSet<OrderDbModel> Orders { get; set; }
}
