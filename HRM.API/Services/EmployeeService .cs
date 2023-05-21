using HRM.API.Model;
using HRM.API.Repository;

namespace HRM.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _employeeRepository = repository;
        }

        public Task<string> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<string> EditEmployee(int id, Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public  async Task<IEnumerable<Employee>> GetEmployees()
        {
            return  await _employeeRepository.SelectAllEmployees();
        }

        public Task<string> RemoveEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
