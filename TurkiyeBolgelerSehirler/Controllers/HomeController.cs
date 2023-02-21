using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TurkiyeBolgelerSehirler.Data;
using TurkiyeBolgelerSehirler.Models;

namespace TurkiyeBolgelerSehirler.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UygulamaDbContext _db;

        public HomeController(ILogger<HomeController> logger, UygulamaDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Bolgeler.ToList());
        }

        [Route("bolge/{slug}")]
        public IActionResult BolgeBilgi(string slug)
        {
            var bolge = _db.Bolgeler.Include(x => x.Sehirler).FirstOrDefault(x => x.Slug == slug);

            if (bolge == null) return NotFound();

            return View(bolge);
        }

        [Route("sehir/{slug}")]
        public IActionResult SehirBilgi(string slug)
        {
            var sehir = _db.Sehirler.Include(x => x.Bolge).FirstOrDefault(x => x.Slug == slug);

            if (sehir == null) return NotFound();

            return View(sehir);
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