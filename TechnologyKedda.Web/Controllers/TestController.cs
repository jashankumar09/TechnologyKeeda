using Microsoft.AspNetCore.Mvc;

namespace TechnologyKedda.Web.Controllers
{
    public class TestController : Controller
    {
        static int a = 0;
        //{basepath(localhost:50001}/Test/Showbutton
        public IActionResult ShowButton()
        {
            
            return View();
        }
        public IActionResult ClickAction()
        {
            ++a;
            return View("ShowButton", a);
        }
    }
}
