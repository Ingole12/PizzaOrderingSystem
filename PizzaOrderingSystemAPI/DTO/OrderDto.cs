namespace PizzaOrderingSystemAPI.DTO
{
    public class OrderDto
    {
        public DateTime OrderDateTime { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public string OrderStatus { get; set; }
        public int TotalPrice { get; set; }
    }
}
