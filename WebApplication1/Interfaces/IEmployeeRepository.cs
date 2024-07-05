using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetAll();
        public Task<Employee> GetById(int id);
        public bool AddEmployee(Employee employee);
        public bool DeleteEmployee(Employee employee);
        public bool UpdateEmployee(Employee employee);
        public bool Save();
    }
}
