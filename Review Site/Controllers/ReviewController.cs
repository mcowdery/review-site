using Microsoft.AspNetCore.Mvc;

namespace Review_Site.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}