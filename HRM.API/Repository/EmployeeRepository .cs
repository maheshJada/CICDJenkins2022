using HRM.API.Db;
using HRM.API.Model;
using Microsoft.EntityFrameworkCore;

namespace HRM.API.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HRMContext _context;

        public EmployeeRepository(HRMContext context)
        {
            _context = context;
        }

        public Task<string> DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> SelectAllEmployees()
        {
            var allemployess = _context.Employees.ToListAsync();
            return await allemployess;
        }

        public Task<Employee> SelectEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateEmployee(int id, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
