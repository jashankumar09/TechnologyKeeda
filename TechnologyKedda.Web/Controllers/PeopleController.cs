using Microsoft.AspNetCore.Mvc;
using TechnologyKedda.Web.Data;
using TechnologyKedda.Web.Models;

namespace TechnologyKedda.Web.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var people = _context.Peoples.ToList();
            return View(people);
        }
        //httpget-url query people/index   

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(People people)
        {
            _context.Peoples.Add(people);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var people = _context.Peoples.Find(id);
            return View(people);
        }
        public IActionResult Edit(People people)
        {
            _context.Peoples.Update(people);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var people = _context.Peoples.Find(id);
            return View(people);
        }
        public IActionResult Delete(People people)
        {
            _context.Peoples.Remove(people);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
