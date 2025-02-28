using Microsoft.AspNetCore.Mvc;
using PetManagement.Data;
using PetManagement.Models;

namespace PetManagement.Controllers
{
    public class PetController : Controller
    {
        private readonly AppDbContext _context;
        public PetController(AppDbContext context) => _context = context;

        public IActionResult Index()
        {
            var pets = _context.Pets.ToList();
            return View(pets);
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
