using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Data;


namespace WebApplication1.Controllers
{
    public class CinemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly CinemaContext _context;

        public CinemaController(CinemaContext context)
        {
            _context = context;
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
        public ActionResult List()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        private CinemaModel Get(int Id1)
        {
            List<CinemaModel> Cinema = _context.Movies.ToList();
            foreach (CinemaModel movies in Cinema)
            {
                //Console.WriteLine(employee);
                if (movies.Id == Id1)
                {
                    return movies;
                }
            }
            return null;
        }
        public ActionResult Edit(int Id)
        {
            var movies = this.Get(Id);
            return View(movies);
        }

        public ActionResult New()
        {

            return View("Edit");
        }

        public ActionResult Update(int Id, CinemaModel movieForm)
        {
            var movies = this.Get(Id);

            if (movies == null)
            {

                CinemaModel movies1 = new(

                     0,
                     movieForm.movieGenre,
                     movieForm.mName,
                     movieForm.dName,
                     movieForm.language,
                     movieForm.hall,
                     movieForm.duration,
                     movieForm.features,
                     movieForm.topic
                );

                _context.Movies.Add(movies1); // Assuming _context is your DbContext


            }
            else
            {

                movies.Id = Id;
                movies.movieGenre = movieForm.movieGenre;
                movies.mName = movieForm.mName;
                movies.dName = movieForm.dName;
                movies.features = movieForm.features;
                movies.topic = movieForm.topic;
                movies.duration = movieForm.duration;
                movies.hall = movieForm.hall;
                movies.language = movieForm.language;


            }
            _context.SaveChanges();

            return View("Edit", movies);
        }

    }
}
