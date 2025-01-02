using System;
using System.IO;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using _03EntityFramework.Model;

namespace _03EntityFramework.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("myCon");
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string 'myCon' not found in appsettings.json.");
            }

            optionsBuilder.UseSqlServer(connectionString);
        }

        public Employee GetEmployeeById(int id)
        {
            var idParam = new SqlParameter("@id", id);
            return employees
                .FromSqlRaw("EXEC GetEmployeeById @id", idParam)
                .AsEnumerable()
                .FirstOrDefault();
        }
    }
}
