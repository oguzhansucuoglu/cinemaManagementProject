using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Data;


namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }

        public ActionResult List()
        {
            var employees = _context.Employee.ToList();
            return View(employees);
        }
    }
}
