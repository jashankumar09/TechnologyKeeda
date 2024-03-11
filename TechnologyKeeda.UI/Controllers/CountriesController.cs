using Microsoft.AspNetCore.Mvc;

namespace TechnologyKeeda.UI.Controllers
{
    public class CountriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
