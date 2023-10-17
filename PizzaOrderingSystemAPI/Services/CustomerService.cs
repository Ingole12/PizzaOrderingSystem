using PizzaOrderingSystemAPI.Repository;

namespace PizzaOrderingSystemAPI.Services
{
    public class CustomerService
    {
        // dependency injection repository to service
        private readonly CustomerRepository _customerRepository;
        public CustomerService( CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }



    }
}
