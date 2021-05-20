using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderWebAPI
{

    public class OrderDbContext : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“Model1”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“OrderSQL.Model1”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“Model1”
        //连接字符串。
        public OrderDbContext(DbContextOptions<OrderDbContext> options):base(options)
        {
            this.Database.EnsureCreated();
        }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

         public DbSet<Order> Orders { get; set; }
         public DbSet<OrderDetail> OrderDetails { get; set; }
    }

    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public List<OrderDetail> OrderDetails{ get; set; }
        [NotMapped]
        public int OrderPrice
        {
            get
            {
                int sum = 0;
                if(OrderDetails!=null)
                OrderDetails.ForEach(od => sum += od.GoodTotalPrice);
                return sum;
            }
        }
    }

    public class OrderDetail
    {
        [Key]
        public int GoodId { get; set; }
        public string GoodName { get; set; }
        public int GoodPrice { get; set; }
        public int GoodNum { get; set; }
        public Order order { get; set; }
        [ForeignKey("order")]
        public int OrderId { get; set; }
        [NotMapped]
        public int GoodTotalPrice { get => GoodPrice * GoodNum; }

    }
}