namespace OrderSQL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OrderSQL.OrderDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OrderSQL.OrderDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Orders.Add(new Order { OrderId = 1, Customer = "aaa" });
            context.Orders.Add(new Order { OrderId = 2, Customer = "bbb" });
            context.OrderDetails.Add(new OrderDetail { GoodId = 1, GoodName = "&&", GoodPrice = 12, GoodNum = 2, OrderId = 1 });
            context.OrderDetails.Add(new OrderDetail { GoodId = 2, GoodName = "**", GoodPrice = 2, GoodNum = 32, OrderId = 2 });
            context.SaveChanges();
        }
    }
}
