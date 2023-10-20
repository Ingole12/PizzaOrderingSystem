using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemAPI.DBContext;
using PizzaOrderingSystemAPI.Models.Customer;
using System.Security.Cryptography;


namespace PizzaOrderingSystemAPI.Repository
{
    public class CustomerRepository
    {
        private readonly PizzaOrderingSystemAPI_DbContext _pizzaOrderingDbContext;
        private readonly ILogger<CustomerRepository> _logger;
        public CustomerRepository(PizzaOrderingSystemAPI_DbContext dbContext, ILogger<CustomerRepository> logger)
        {
            _pizzaOrderingDbContext = dbContext;
            _logger = logger;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _pizzaOrderingDbContext.Customer.ToList();
        }
        public async Task<Customer> GetCustomerById(int CustomerId)
        {
            return await _pizzaOrderingDbContext.Customer.FindAsync(CustomerId);
        }

        public Customer AddCustomer(Customer customer)
        {
            try
            {
                var newCustomer = new Customer
                {
                    //CustomerId = customer.CustomerId,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    City = customer.City,
                    Street = customer.Street,
                    HouseNumber = customer.HouseNumber,
                    Email = customer.Email

                };
                _pizzaOrderingDbContext.Customer.Add(newCustomer);

                _pizzaOrderingDbContext.SaveChanges();
                return newCustomer;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in the repository.");
                throw new RepositoryException("An error occurred in the repository.", ex);
            }

        }


        public Customer UpdateCustomer(int customerId, Customer customer)
        {

            var cId = _pizzaOrderingDbContext.Customer.Find(customerId);
            if (cId != null)
            {
                cId.CustomerId = customer.CustomerId;
                cId.FirstName = customer.FirstName;
                cId.LastName = customer.LastName;
                cId.City = customer.City;
                cId.Street = customer.Street;
                cId.HouseNumber = customer.HouseNumber;
                cId.Email = customer.Email;

                _pizzaOrderingDbContext.SaveChanges();
                return cId;
            }
            else
            {
                return null;
            }

        }

        public Customer DeleteCustomer(int CustomerId)
        {
            var Customer = _pizzaOrderingDbContext.Customer.Find(CustomerId);
            if (Customer != null)
            {
                _pizzaOrderingDbContext.Customer.Remove(Customer);
                _pizzaOrderingDbContext.SaveChanges();
                return Customer;

            }
            else
            {
                return null;
            }
        }


        public void SaveChanges()
        {
            _pizzaOrderingDbContext.SaveChanges();
        }
    }
}
