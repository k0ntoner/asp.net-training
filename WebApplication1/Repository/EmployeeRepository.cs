using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) 
        { 
            _context = context;
        }
        public bool AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            return Save();
        }

        public bool DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            return Save();
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.Include(e=>e.Library).Include(e => e.Position).ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public bool Save()
        {
            int saved = _context.SaveChanges();
            return saved >0 ? true:false;
        }

        public bool UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            return Save();
        }
    }
}
