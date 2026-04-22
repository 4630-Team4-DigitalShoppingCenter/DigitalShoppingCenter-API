using DigitalShoppingCenter.Domain.Catalog;
using DigitalShoppingCenter.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace DigitalShoppingCenter.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}