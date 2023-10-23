using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemAPI.DBContext;
using PizzaOrderingSystemAPI.DTO;
using PizzaOrderingSystemAPI.Models.DeliveryEmployee;

namespace PizzaOrderingSystemAPI.Repository
{
    public class DeliveryEmployeeRepository
    {
        private readonly PizzaOrderingSystemAPI_DbContext _pizzaOrderingDbContext;
        private readonly ILogger<DeliveryEmployeeRepository> _logger;
        public DeliveryEmployeeRepository(PizzaOrderingSystemAPI_DbContext dbContext, ILogger<DeliveryEmployeeRepository> logger)
        {
            _pizzaOrderingDbContext = dbContext;
            _logger = logger;
        }

        public List<Employee> GetAll()
        {
          return  _pizzaOrderingDbContext.Employees.ToList();
        }

        public Employee GetEmployeeById (int id)
        {
            var emp = _pizzaOrderingDbContext.Employees.Find(id);

            if (emp != null)
            {
                return emp;
            }
            else
            {
                return null;
            }
        }

        public Employee AddEmployee(EmployeeDto employee)
        {
            var Emp = new Employee
            {
               // employeeId = employee.employeeId,
                employeeName = employee.employeeName,
                employeeAge = employee.employeeAge,
                employeePassword = employee.employeePassword
            };
            _pizzaOrderingDbContext.Employees.Add(Emp);
            _pizzaOrderingDbContext.SaveChanges();
            return Emp;

        }

        public Employee? UpdateEmployee( int Eid, EmployeeDto employee)
        {
            var Emp = _pizzaOrderingDbContext.Employees.Find(Eid);

            if (Emp != null )
            {
                var NewEmp = new Employee
                {
                    employeeAge = employee.employeeAge,
                    employeeName = employee.employeeName,
                    employeePassword = employee.employeePassword
                };

                _pizzaOrderingDbContext.Employees.Update(NewEmp);
                _pizzaOrderingDbContext.SaveChanges();  
                return NewEmp;
            }
            else
            {
                return null;
            }
        }

        public Employee DeleteEmp(int id)
        {
            var Emp = _pizzaOrderingDbContext.Employees.Find(id);

            if (Emp != null ) { 
                _pizzaOrderingDbContext.Employees.Remove(Emp);
                _pizzaOrderingDbContext.SaveChanges();
                return Emp;
            }
            else
            {
                return null;
            }
        }

    }
}
