using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemAPI.Models.Customer;
using PizzaOrderingSystemAPI.Repository;

namespace PizzaOrderingSystemAPI.Services
{
    public class CustomerService
    {
        // dependency injection repository to service
        private readonly CustomerRepository _customerRepository;
        public CustomerService(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _customerRepository.GetAll();
        }
        public Task<Customer> GetCustomerById(int customerId)
        {
            if (customerId != null)
            {
                return _customerRepository.GetCustomerById(customerId);
            }
            else
            {
                return null;
            }
        }

        public Customer AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        public Customer UpdateCustomer(int CustomerId, Customer customer)
        {
            return _customerRepository.UpdateCustomer(CustomerId, customer);
        }

        public Customer DeleteCustomer(int customerId)
        {
            return _customerRepository.DeleteCustomer(customerId);
        }
    }
}
