using Microsoft.EntityFrameworkCore;
using PizzaOrderingSystemAPI.Models.Customer;
using PizzaOrderingSystemAPI.Models.DeliveryEmployee;
using PizzaOrderingSystemAPI.Models.Order;
using PizzaOrderingSystemAPI.Models.Pizza;

namespace PizzaOrderingSystemAPI.DBContext
{
    public class PizzaOrderingSystemAPI_DbContext : DbContext
    {
        public PizzaOrderingSystemAPI_DbContext(DbContextOptions<PizzaOrderingSystemAPI_DbContext> options) : base(options)
        {

        }

      public  DbSet<Customer> Customer { get; set; }
      public  DbSet<Order> Orders { get; set; }
      public  DbSet<Employee> Employees { get; set; }
      public  DbSet<Pizza> Pizza { get; set; }
    }
}
