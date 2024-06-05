using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext(DbContextOptions<DepartmentContext> options) : base(options)
        {
        }

        public DbSet<DepartmentModel> Department { get; set; }
    }
}