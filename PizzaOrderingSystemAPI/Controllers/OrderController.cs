using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using PizzaOrderingSystemAPI.DTO;
using PizzaOrderingSystemAPI.Models.Order;
using PizzaOrderingSystemAPI.Services;


namespace PizzaOrderingSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController
    {
        private readonly OrderService _orderService;
        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("GetAll")]
        public  Task<IEnumerable<Order>> GetAll()
        {
            try
            {
                 return   _orderService.GetAllOrders();
            }
            catch (Exception ex)
            {
                return null;
                //StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public Task<ActionResult<Order>> AddOrder(OrderDto order)
        {
            try
            {
                return _orderService.AddOrder(order);
            }   
            catch(Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public Task<ActionResult<Order>> GetOrderById(int id)
        {
            try
            {
                return _orderService.GetOrderById(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPut]
        [Route("{id:int}")]

        public Task<Order> UpdateOrder(int id,  OrderDto order)
        {
            try
            {
                return _orderService.UpdateOrder(id, order);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public Task<Order> DeleteOrder(int id)
        {
            return _orderService.DeleteOrder(id);
        }
    }
}
