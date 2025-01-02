using Microsoft.EntityFrameworkCore;

namespace _02CodeFirstApp.Models
{
    public class EmpDbContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }

        public EmpDbContext(DbContextOptions options) : base(options)
        { 

        }
    }
}
