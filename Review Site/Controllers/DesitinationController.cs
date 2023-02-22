using Microsoft.AspNetCore.Mvc;
using Review_Site.Data;
using Review_Site.Models;

namespace Review_Site.Controllers
{
    public class DestinationController : Controller
    {
        private readonly ReviewSiteContext _context;

        public DestinationController(ReviewSiteContext context)
        {
            _context = context; 
        }
        public ActionResult Index()
        {
            return View(_context.Destinations.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(DestinationModel destination)
        {
            if (ModelState.IsValid)
            {
                _context.Destinations.Add(destination);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(destination);
        }
    }
}
