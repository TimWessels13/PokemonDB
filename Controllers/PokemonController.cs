using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pokemon.Data;
using Pokemon.Models;

namespace Pokemon_DB.Controllers
{
    public class PokemonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PokemonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pokemon
        public async Task<IActionResult> Index(string searchString)
        {
            PokemonView pv = new PokemonView();
            pv.Pokemon = _context.Pokemon.OrderBy(p => p.Number).ToList();
            pv.PokeType = _context.PokeType.ToList();
            pv.PokemonType = _context.PokemonType.ToList();
            pv.Color = _context.Color.ToList();
            pv.Gender = _context.Gender.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                pv.Pokemon = pv.Pokemon.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
            }

            return View(pv);
        }

        // GET: Pokemon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pok = await _context.Pokemon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pok == null)
            {
                return NotFound();
            }

            PokemonView pv = new PokemonView();
            pv.Pokemon = _context.Pokemon.Where(p => p.Id == id).ToList();
            pv.PokeType = _context.PokeType.ToList();
            pv.PokemonType = _context.PokemonType.ToList();
            pv.Color = _context.Color.ToList();
            pv.Gender = _context.Gender.ToList();
            return View(pv);
        }
    }
}
