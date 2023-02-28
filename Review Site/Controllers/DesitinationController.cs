﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            return View(_context.Destinations
                .Include(p => p.Reviews).ToList());
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
                //return Problem("Entity set 'GameContext.BoardGames is null");
                _context.Destinations.Add(destination);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            //return Problem("Entity set 'GameContext.BoardGames is something else");
            return View(destination);
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var destination = _context.Destinations.FirstOrDefault(
                g => g.Id == id);
            if (destination == null)
            {
                return NotFound();
            }
            return View(destination);
        }

        //the http delete method doesnt delete the specified game, it returns a view of the game wher you can submit the deletion
        [HttpPost]
        public ActionResult Delete(int? id, bool notUsed)
        {
            if (_context.Destinations == null)
            {
                return Problem("Entity set 'GameContext.BoardGames is null");
            }
            var destination = _context.Destinations.Find(id);
            _context.Destinations.Remove(destination);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, DestinationModel destination)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(destination).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(destination);
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var destination = _context.Destinations.Find(id);
            return View(destination);
        }

        //public ActionResult ReviewsList(int id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var destination = _context.Destinations.Find(id);
        //    return View(destination);


        //        return View(_context.Destinations
        //            .Include(p => p.Reviews).ToList());

        //    private List<sel> ReviewsList()
        //    {
        //        var list = _context.Destinations.ToList();
        //        List<SelectListItem> retValue = list.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
        //        return retValue;
        //    }
        }
}
