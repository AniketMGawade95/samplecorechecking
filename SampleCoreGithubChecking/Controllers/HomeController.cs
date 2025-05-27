using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SampleCoreGithubChecking.Data;
using SampleCoreGithubChecking.Models;

namespace SampleCoreGithubChecking.Controllers
{
    public class HomeController : Controller
    {
        DemosampleContext db;
        //public HomeController(DemosampleContext db)
        //{
        //    this.db = db;
        //}

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DemosampleContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            var data= db.SampleStudents.ToList();
            return View(data);
        }

        public IActionResult addstudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addstudent(SampleStudent s)
        {
            db.SampleStudents.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
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
