using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechnologyKedda.Web.Models;

namespace TechnologyKedda.Web.Controllers
{
    //localhost:port/controllername/actionname
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<People>people = new List<People>();
            people.Add(new People { Id=1, Name = "Tarun", City="Jaipur" });
            people.Add(new People { Id = 2, Name = "Ram", City = "Delhi" });
            people.Add(new People { Id = 3, Name = "sham", City = "kota" });
            people.Add(new People { Id = 4, Name = "mohan", City = "Ajmer" });

            //People people = new People();
            //people.Id = 1;
            //people.Name = "Tarun";
            //people.City = "Jaipur";
            //string a = "10";
            //  int a = 10;
            return View("index",people);
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