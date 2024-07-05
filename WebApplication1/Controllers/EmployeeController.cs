using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class EmployeeController : Controller
    {
        
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeeRepository)
        {
            
            _employeeRepository = employeeeRepository;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            IEnumerable<Employee> employees = await _employeeRepository.GetAll();

            return View(employees);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Employee employee = await _employeeRepository.GetById(id);
            return Ok(employee);
        }
        public IActionResult CreateEmployee()
        {
			
            return View();
        }
        [HttpPost]
		public async Task<IActionResult> CreateEmployee(Employee employee)
		{
            
			if(!ModelState.IsValid)
            {
                return View(employee);
            }
            _employeeRepository.AddEmployee(employee);

            return RedirectToAction("Index");
		}
	}
}
