using Microsoft.AspNetCore.Mvc;
using PetManagement.Data;
using PetManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace PetManagement.Controllers
{
    public class OwnersController : Controller
    {
        private readonly AppDbContext _context;

        public OwnersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Owners
        public IActionResult Index()
        {
            var owners = _context.Owners.ToList();
            return View(owners);
        }

        // GET: Owners/Details/5
        public IActionResult Details(int id)
        {
            var owner = _context.Owners.FirstOrDefault(o => o.Id == id);
            if (owner == null)
            {
                return NotFound();
            }
            return View(owner);
        }

        // GET: Owners/Create

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Owner owner)
        {
            _context.Owners.Add(owner);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Owners/Edit/5
        public IActionResult Edit(int id)
        {
            var owner = _context.Owners.Find(id);
            if (owner == null)
            {
                return NotFound();
            }
            return View(owner);
        }

        // POST: Owners/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Owner owner)
        {
            if (id != owner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(owner);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(owner);
        }

        // GET: Owners/Delete/5
        public IActionResult Delete(int id)
        {
            var owner = _context.Owners.Find(id);
            if (owner == null)
            {
                return NotFound();
            }
            return View(owner);
        }

        // POST: Owners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var owner = _context.Owners.Find(id);
            _context.Owners.Remove(owner);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
