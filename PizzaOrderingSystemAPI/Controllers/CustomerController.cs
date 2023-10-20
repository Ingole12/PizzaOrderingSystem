using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemAPI.Models.Customer;
using PizzaOrderingSystemAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaOrderingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;
        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }


        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerService.GetAllCustomer();
        }

        // GET api/<CustomerController>/5
        [HttpGet]
        [Route("{id:int}")]
        public Task<Customer> Get([FromRoute] int id)
        {
            if (id != null)
            {
                return _customerService.GetCustomerById(id);
            }
            else
            {
                return null;
            }
        }

        // POST api/<CustomerController>
        [HttpPost]
        public Customer Post(Customer customer)
        {
            return _customerService.AddCustomer(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut]
        [Route("{id:int}")]
        public Customer Put(int id, Customer customer)
        {
           return _customerService.UpdateCustomer(id, customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete]
        [Route("{id:int}")]
        public Customer Delete(int id)
        {
            return _customerService.DeleteCustomer(id);
        }
    }
}
