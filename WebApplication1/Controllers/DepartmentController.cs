using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly DepartmentContext _context;

        public DepartmentController(DepartmentContext context)
        {
            this._context = context;
        }

        public async Task<List<DepartmentModel>> GetListAsync()
        {
            var departments = await _context.Department.ToListAsync();
            return departments;
        }

        public async Task OnGetAsync()
        {
            //var employees = await _context.Employee.ToListAsync();
        }
        public ActionResult Index()
        {

            ViewBag.Message = "Department Example";
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult List()
        {
            var Departments = _context.Department.ToList();
            return View(Departments);
        }

        private DepartmentModel Get(int Id1)
        {
            List<DepartmentModel> Department = _context.Department.ToList();
            foreach (DepartmentModel dept in Department)
            {
                //Console.WriteLine(employee);
                if (dept.Id == Id1)
                {
                    return dept;
                }
            }
            return null;
        }
        public ActionResult Edit(int Id)
        {
            var dept = this.Get(Id);
            return View(dept);
        }

        public ActionResult New()
        {

            return View("Edit");
        }

        public ActionResult Update(int Id, DepartmentModel deptForm)
        {
            var dept = this.Get(Id);

            if (dept == null)
            {

                DepartmentModel dept1 = new(

                     0,
                     deptForm.name,
                     deptForm.managerName
                );

                _context.Department.Add(dept1); // Assuming _context is your DbContext


            }
            else
            {

                dept.Id = Id;
                dept.name = deptForm.name;
                dept.managerName = deptForm.managerName;

            }
            _context.SaveChanges();

            return View("Edit", dept);
        }

    }
}
