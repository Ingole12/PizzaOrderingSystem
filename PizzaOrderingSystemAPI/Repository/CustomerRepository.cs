using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemAPI.DBContext;
using PizzaOrderingSystemAPI.Models.Customer;


namespace PizzaOrderingSystemAPI.Repository
{
    public class CustomerRepository
    {
        private readonly PizzaOrderingSystemAPI_DbContext _pizzaOrderingDbContext;
        public CustomerRepository(PizzaOrderingSystemAPI_DbContext dbContext)
        {
            _pizzaOrderingDbContext = dbContext;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _pizzaOrderingDbContext.Customer.ToList();
        }
        public async Task<Customer> GetCustomerById(int CustomerId)
        {
            return await _pizzaOrderingDbContext.Customer.FindAsync(CustomerId);
        }

        public void AddCustomer(Customer customer)
        {
            _pizzaOrderingDbContext.Customer.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _pizzaOrderingDbContext.Customer.Update(customer);
        }

        public void DeleteCustomer(int CustomerId)
        {
            var Customer = _pizzaOrderingDbContext.Customer.Find(CustomerId);
            if (Customer != null)
            {
                _pizzaOrderingDbContext.Customer.Remove(Customer);

            }
        }


        public void SaveChanges()
        {
            _pizzaOrderingDbContext.SaveChanges();
        }
    }
}
