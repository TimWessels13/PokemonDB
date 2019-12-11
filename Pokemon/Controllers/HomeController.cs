using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pokemon.Data;
using Pokemon.Models;

namespace Pokemon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;

            if (_context.Color.Count() == 0)
            {
                _context.Color.Add(new Color { Name = "Red" });
                _context.Color.Add(new Color { Name = "Blue" });
                _context.Color.Add(new Color { Name = "Yellow" });
                _context.Color.Add(new Color { Name = "Green" });
                _context.Color.Add(new Color { Name = "Black" });
                _context.Color.Add(new Color { Name = "Brown" });
                _context.Color.Add(new Color { Name = "Purple" });
                _context.Color.Add(new Color { Name = "Gray" });
                _context.Color.Add(new Color { Name = "White" });
                _context.Color.Add(new Color { Name = "Pink" });
                _context.SaveChanges();
            }

            if (_context.Gender.Count() == 0)
            {
                _context.Gender.Add(new Gender { Name = "Male" });
                _context.Gender.Add(new Gender { Name = "Female" });
                _context.Gender.Add(new Gender { Name = "Male and Female" });
                _context.Gender.Add(new Gender { Name = "Genderless" });
                _context.SaveChanges();
            }

            if (_context.PokeType.Count() == 0)
            {
                _context.PokeType.Add(new PokeType { Name = "Bug", ImageFileName = "Bug.png" });
                _context.PokeType.Add(new PokeType { Name = "Dark", ImageFileName = "Dark.png" });
                _context.PokeType.Add(new PokeType { Name = "Dragon", ImageFileName = "Dragon.png" });
                _context.PokeType.Add(new PokeType { Name = "Electric", ImageFileName = "Electric.png" });
                _context.PokeType.Add(new PokeType { Name = "Fairy", ImageFileName = "Fairy.png" });
                _context.PokeType.Add(new PokeType { Name = "Fighting", ImageFileName = "Fighting.png" });
                _context.PokeType.Add(new PokeType { Name = "Fire", ImageFileName = "Fire.png" });
                _context.PokeType.Add(new PokeType { Name = "Flying", ImageFileName = "Flying.png" });
                _context.PokeType.Add(new PokeType { Name = "Ghost", ImageFileName = "Ghost.png" });
                _context.PokeType.Add(new PokeType { Name = "Grass", ImageFileName = "Grass.png" });
                _context.PokeType.Add(new PokeType { Name = "Ground", ImageFileName = "Ground.png" });
                _context.PokeType.Add(new PokeType { Name = "Ice", ImageFileName = "Ice.png" });
                _context.PokeType.Add(new PokeType { Name = "Normal", ImageFileName = "Normal.png" });
                _context.PokeType.Add(new PokeType { Name = "Poison", ImageFileName = "Poison.png" });
                _context.PokeType.Add(new PokeType { Name = "Psychic", ImageFileName = "Psychic.png" });
                _context.PokeType.Add(new PokeType { Name = "Rock", ImageFileName = "Rock.png" });
                _context.PokeType.Add(new PokeType { Name = "Steel", ImageFileName = "Steel.png" });
                _context.PokeType.Add(new PokeType { Name = "Water", ImageFileName = "Water.png" });
                _context.SaveChanges();
            }
        }

        public IActionResult Index()
        {
            return View();
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
