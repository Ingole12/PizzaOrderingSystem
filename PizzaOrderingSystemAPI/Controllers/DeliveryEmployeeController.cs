using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemAPI.DTO;
using PizzaOrderingSystemAPI.Models.DeliveryEmployee;
using PizzaOrderingSystemAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaOrderingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryEmployeeController : ControllerBase
    {
        private readonly DeliveryEmployeeService _deliveryEmployeeService;

        public DeliveryEmployeeController(DeliveryEmployeeService deliveryEmployeeService)
        {
            _deliveryEmployeeService = deliveryEmployeeService;
        }


        // GET: api/<DeliveryEmployeeController>
        [HttpGet]
        public List<Employee> Get()
        {
            return _deliveryEmployeeService.GetAll();
        }

        // GET api/<DeliveryEmployeeController>/5
        [HttpGet]
        [Route("{id:int}")]
        public Employee GetEmployeeById([FromRoute] int id)
        {
            return _deliveryEmployeeService.GetEmployeeById(id);
        }
        


        // POST api/<DeliveryEmployeeController>
        [HttpPost]
        public Employee AddEmployee(EmployeeDto emp)
        {
            return _deliveryEmployeeService.AddEmployee(emp);
        }

        // PUT api/<DeliveryEmployeeController>/5
        [HttpPut]
        [Route("{id:int}")]
        public Employee? UpdateEmployee([FromRoute] int id, EmployeeDto emp)
        {
            return _deliveryEmployeeService.UpdateEmp(id, emp);
        }


        // DELETE api/<DeliveryEmployeeController>/5
        [HttpDelete]
        [Route("{id:int}")]
        public Employee Delete(int id)
        {
            return _deliveryEmployeeService.DeleteEmp(id);
        }
    }
}
