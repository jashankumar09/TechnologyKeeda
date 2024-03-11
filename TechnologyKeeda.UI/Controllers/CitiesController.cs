using Microsoft.AspNetCore.Mvc;

namespace TechnologyKeeda.UI.Controllers
{
    public class CitiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
