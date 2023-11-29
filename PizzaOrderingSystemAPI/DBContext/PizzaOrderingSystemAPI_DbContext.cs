using Microsoft.EntityFrameworkCore;
using PizzaOrderingSystemAPI.Models.Customer;
using PizzaOrderingSystemAPI.Models.DeliveryEmployee;
using PizzaOrderingSystemAPI.Models.Order;
using PizzaOrderingSystemAPI.Models.Pizza;
using PizzaOrderingSystemAPI.Models.UserTable;

namespace PizzaOrderingSystemAPI.DBContext
{
    public class PizzaOrderingSystemAPI_DbContext : DbContext
    {
        public PizzaOrderingSystemAPI_DbContext(DbContextOptions<PizzaOrderingSystemAPI_DbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Pizza> Pizza { get; set; }

        //All Requred model class for the entity freamwork tables 
        public DbSet<RegistrationModel> Registration { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<LogInModel> Login { get; set; }
        public DbSet<ApplicationUserModel> ApplicationUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUserModel>().HasNoKey();
            modelBuilder.Entity<LogInModel>().HasNoKey();
            modelBuilder.Entity<RegistrationModel>().HasNoKey();
            modelBuilder.Entity<UserModel>().HasNoKey();

        }

    }
}
