using Microsoft.EntityFrameworkCore;
using TestAPI2.Controllers;

namespace TestAPI2.Model
{
    public class EmployeDbContext : DbContext


    {
        public EmployeDbContext(DbContextOptions<EmployeDbContext> options) : base(options)
        {
        }

        public DbSet<Employe> emps { get; set; }
    }
}
