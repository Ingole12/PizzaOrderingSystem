using PizzaOrderingSystemAPI.DTO;
using PizzaOrderingSystemAPI.Models.DeliveryEmployee;
using PizzaOrderingSystemAPI.Repository;

namespace PizzaOrderingSystemAPI.Services
{
    public class DeliveryEmployeeService
    {
        private readonly DeliveryEmployeeRepository _DeliveryEmployeeService;
        public DeliveryEmployeeService(DeliveryEmployeeRepository employeeRepository)
        {
            _DeliveryEmployeeService = employeeRepository;
        }

        public List<Employee> GetAll()
        {
            return _DeliveryEmployeeService.GetAll();
        }

        public Employee GetEmployeeById(int id)
        {
            return _DeliveryEmployeeService.GetEmployeeById(id);
        }

        public Employee AddEmployee(EmployeeDto emp)
        {
            return _DeliveryEmployeeService.AddEmployee(emp);
        }

        public Employee? UpdateEmp(int id, EmployeeDto emp)
        {
            return _DeliveryEmployeeService.UpdateEmployee(id, emp);
        }

        public Employee DeleteEmp(int id)
        {
            return _DeliveryEmployeeService.DeleteEmp(id);
        }
    }
}
