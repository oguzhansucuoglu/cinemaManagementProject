using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CinemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ticket()
        {
            return View("Ticket");
        }
        public IActionResult TicketSave()
        {
            return View("TicketInformation");
        }
        public IActionResult AddMovie()
        {
            return View("AddMovie");
        }
        public IActionResult movieSave(CinemaModel movie)
        {
            if (ModelState.IsValid)
            {
                //*
            }

            ViewBag.mName = movie.mName;

            return View("movieList");
        }
        public IActionResult List()
        {
            var movies = CinemaModel.GetList();
            return View(movies);
        }
        public IActionResult Edit(int Id)
        {
            var movies = CinemaModel.Get(Id);
            return View(movies);
        }
    }
}
