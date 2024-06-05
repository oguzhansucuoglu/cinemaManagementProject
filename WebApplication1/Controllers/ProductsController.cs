using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ApplicationSave()
        {
            string department;
            department = HttpContext.Request.Form["department"];
            ViewBag.department = department;

            string idNo;
            idNo = HttpContext.Request.Form["idNo"];
            long id = 0;
            if (idNo != null) {id = long.Parse(idNo); }
            
            ViewBag.idNo = id;

            string fname;
            fname = HttpContext.Request.Form["fname"];
            ViewBag.fname = fname;

            string lname;
            lname = HttpContext.Request.Form["lname"];
            ViewBag.lname = lname;

            string gradStat;
            gradStat = HttpContext.Request.Form["gradStat"];
            ViewBag.gradStat = gradStat;

            string school;
            school = HttpContext.Request.Form["school"];
            ViewBag.school = school;

            string sAge;
            sAge = HttpContext.Request.Form["age"];
            int age = Int32.Parse(sAge);
            ViewBag.age = age;

            string mStatus;
            mStatus = HttpContext.Request.Form["mStatus"];
            ViewBag.mStatus = mStatus;

            string motivation;
            motivation = HttpContext.Request.Form["motivation"];
            ViewBag.motivation = motivation;

            string email;
            email = HttpContext.Request.Form["email"];
            ViewBag.email = email;

            string FullTime;
            FullTime = HttpContext.Request.Form["cb1"];
            ViewBag.FullTime = FullTime;

            string PartTime;
            PartTime = HttpContext.Request.Form["cb2"];
            ViewBag.PartTime = PartTime;

            string Internship;
            Internship = HttpContext.Request.Form["cb3"];
            ViewBag.Internship = Internship;

            return View("applicationFormResult");
        }

        public IActionResult ProductsForm()
        {
            return View("ProductsForm");
        }
    }
}
