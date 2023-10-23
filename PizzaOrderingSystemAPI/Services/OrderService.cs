using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemAPI.DTO;
using PizzaOrderingSystemAPI.Models.Order;
using PizzaOrderingSystemAPI.Repository;

namespace PizzaOrderingSystemAPI.Services
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;
        public OrderService(OrderRepository order)
        {
            _orderRepository = order;
        }

        public Task<IEnumerable<Order>> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public async Task<ActionResult<Order>> AddOrder(OrderDto order)
        {
            return await _orderRepository.AddOrder(order);
        }

        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            return await _orderRepository.GetOrderById(id);
        }

        public async Task<Order> UpdateOrder(int id, OrderDto orderDto)
        {
            return await _orderRepository.UdateOrder(id, orderDto);
        }

        public async Task<Order> DeleteOrder(int id)
        {
            return await _orderRepository.DeleteOrder(id);
        }
    }
}
