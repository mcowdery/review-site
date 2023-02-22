using Microsoft.AspNetCore.Mvc;
using Review_Site.Data;

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
    }
}
