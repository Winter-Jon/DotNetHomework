using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderDbContext orderDb;
        public OrderController(OrderDbContext orderDb)
        {
            this.orderDb = orderDb;
        }
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            var query = orderDb.Orders.ToList();
            return query;
        }
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var query = orderDb.Orders.FirstOrDefault(o => o.OrderId == id);
            if (query == null)
                return NotFound();
            return query;
        }
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(int id,Order order)
        {
            if (order.OrderId != id)
                return BadRequest("Id is not right");
            try
            {
                orderDb.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                string error = e.Message==null?e.InnerException.Message:e.Message;
                return BadRequest(error);
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(int id)
        {
            try
            {
                var order = orderDb.Orders.FirstOrDefault(o => o.OrderId == id);
                if(order!=null)
                {
                    orderDb.Remove(order);
                    orderDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
