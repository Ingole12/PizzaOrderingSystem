using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaOrderingSystemAPI.DBContext;
using PizzaOrderingSystemAPI.DTO;
using PizzaOrderingSystemAPI.Models.Order;

namespace PizzaOrderingSystemAPI.Repository
{
    public class OrderRepository
    {
        private readonly PizzaOrderingSystemAPI_DbContext _pizzaOrderingDbContext;
        public OrderRepository(PizzaOrderingSystemAPI_DbContext dbContext)
        {
            _pizzaOrderingDbContext = dbContext;
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _pizzaOrderingDbContext.Orders.ToListAsync();
        }

        public async Task<ActionResult<Order>> AddOrder(OrderDto orderDto)
        {
            var addedOrder = new Order
            {
                OrderDateTime = orderDto.OrderDateTime,
                DeliveryDateTime = orderDto.DeliveryDateTime,
                OrderStatus = orderDto.OrderStatus,
                TotalPrice = orderDto.TotalPrice
            };


            _pizzaOrderingDbContext.Add(addedOrder);
            await _pizzaOrderingDbContext.SaveChangesAsync();
            return addedOrder;
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _pizzaOrderingDbContext.Orders.FindAsync(id);

        }

        public async Task<Order> UdateOrder(int id, OrderDto order)
        {
            var updateOrder = await _pizzaOrderingDbContext.Orders.FindAsync(id);

            if (updateOrder != null)
            {
                updateOrder.OrderDateTime = order.OrderDateTime;
                updateOrder.DeliveryDateTime = order.DeliveryDateTime;
                updateOrder.OrderStatus = order.OrderStatus;
                updateOrder.TotalPrice = order.TotalPrice;

                _pizzaOrderingDbContext.Update(updateOrder);
                _pizzaOrderingDbContext.SaveChanges();
                return updateOrder;
            }
            else
            {
                return null;
            }
        }

        public async Task<Order> DeleteOrder(int id)
        {

            var removeOrder = await _pizzaOrderingDbContext.Orders.FindAsync(id);

            if (removeOrder != null)
            {
                _pizzaOrderingDbContext.Remove(removeOrder);
                _pizzaOrderingDbContext.SaveChanges();
                return removeOrder;
            }
            else
            {
                return null;
            }
        }
        
    }
}
