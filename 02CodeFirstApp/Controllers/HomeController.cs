using System.Diagnostics;
using _02CodeFirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02CodeFirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmpDbContext _dbContext;

        public HomeController(EmpDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var lst = _dbContext.employees.ToList();    
            return View(lst);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
