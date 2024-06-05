using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
        public class EmployeeContext : DbContext
        {
            public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
            {
            }

            public DbSet<EmployeeModel> Employee { get; set; }
        }
    }

