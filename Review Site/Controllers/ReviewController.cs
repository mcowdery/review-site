using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Review_Site.Data;
using Review_Site.Models;

namespace Review_Site.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ReviewSiteContext _context;

        public ReviewController(ReviewSiteContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View(_context.Reviews.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(ReviewModel reviews)
        {
            if (ModelState.IsValid)
            {
                _context.Reviews.Add(reviews);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reviews);
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var reviews = _context.Reviews.FirstOrDefault(
                g => g.Id == id);
            if (reviews == null)
            {
                return NotFound();
            }
            return View(reviews);
        }

        //the http delete method doesnt delete the specified game, it returns a view of the game wher you can submit the deletion
        [HttpPost]
        public ActionResult Delete(int? id, bool notUsed)
        {
            if (_context.Reviews == null)
            {
                return Problem("Entity set 'GameContext.BoardGames is null");
            }
            var reviews = _context.Reviews.Find(id);
            _context.Reviews.Remove(reviews);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, ReviewModel review)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(review).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var review = _context.Reviews.Find(id);
            return View(review);
        }
    }

}