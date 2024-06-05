using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View("NewCar");
        }
        public IActionResult NewCar(CarModel car)
        {
            if (ModelState.IsValid)
            {
                // *
            }
            ViewBag.Name = car.Name;

            return View("NewCar");

        }
    }
}
