namespace PizzaOrderingSystemAPI.Models.Order
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public int OrderStatus { get; set; }
        public int TotalPrice { get; set; }
    }
}
