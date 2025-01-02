using Microsoft.EntityFrameworkCore;

namespace _02CodeFirstApproach.Models
{
    public class EmpDbContext:DbContext
    {
        public DbSet<Employee> emp { get; set; }

        public EmpDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
