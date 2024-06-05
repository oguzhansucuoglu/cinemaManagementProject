using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class oldEmployeCont : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewEmployee()
        {
            return View("NewEmployee");
        }        
        public IActionResult List()
        {
            var employees = EmployeeModel.GetList();
            return View(employees);
        }
        public IActionResult Edit(int Id)
        {
            var employees = EmployeeModel.Get(Id);
            return View(employees);
        }
    }
}
