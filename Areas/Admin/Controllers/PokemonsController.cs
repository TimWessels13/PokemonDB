using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pokemon.Data;
using Pokemon.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon_Database.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PokemonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PokemonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Pokemon
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

        // GET: Admin/Pokemon/Details/5
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

        // GET: Admin/Pokemon/Create
        public IActionResult Create()
        {
            ViewBag.Poketype = _context.PokeType.ToList();
            ViewData["ColorId"] = new SelectList(_context.Color, "Id", "Name");
            ViewData["GenderId"] = new SelectList(_context.Gender, "Id", "Name");
            return View();
        }

        // POST: Admin/Pokemon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Number,Name,url, GenderId,Generation,ColorId,HP,Attack,Special_Attack,Defense,Special_Defense,Speed")] Pokemon.Models.Pokemon pokemons, int[] poketype)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pokemons);

                var check = _context.Pokemon.FirstOrDefault(w => w.Number == pokemons.Number);
                if (check == null)
                {
                    await _context.SaveChangesAsync();
                    var n = pokemons.Number;
                    if (n <= 151)
                    {
                        pokemons.Generation = 1;
                    }
                    else if (n <= 251)
                    {
                        pokemons.Generation = 2;
                    }
                    else if (n <= 386)
                    {
                        pokemons.Generation = 3;
                    }
                    else if (n <= 493)
                    {
                        pokemons.Generation = 4;
                    }
                    else if (n <= 649)
                    {
                        pokemons.Generation = 5;
                    }
                    else if (n <= 721)
                    {
                        pokemons.Generation = 6;
                    }
                    else if (n <= 809)
                    {
                        pokemons.Generation = 7;
                    }
                    else
                    {
                        pokemons.Generation = 8;
                    }

                    var number = "0";
                    if (pokemons.Number < 10)
                    {
                        number = "00" + pokemons.Number;
                        pokemons.url = number + ".png";
                    }
                    else if (pokemons.Number < 100)
                    {
                        number = "0" + pokemons.Number;
                        pokemons.url = number + ".png";
                    }
                    else
                    {
                        pokemons.url = pokemons.Number + ".png";
                    }

                    foreach (int pt in poketype)
                    {
                        _context.Add(new PokemonType { PokeTypeId = pt, PokemonsId = pokemons.Id });
                    }
                    await _context.SaveChangesAsync();
                }
                else
                {
                    //doe niets
                }

                return RedirectToAction(nameof(Index));
            }
            return View(pokemons);
        }

        // GET: Admin/Pokemon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemons = await _context.Pokemon.FindAsync(id);
            if (pokemons == null)
            {
                return NotFound();
            }

            ViewBag.Poketype = _context.PokeType.ToList();
            ViewData["ColorId"] = new SelectList(_context.Color, "Id", "Name", pokemons.ColorId);
            ViewData["GenderId"] = new SelectList(_context.Gender, "Id", "Name", pokemons.GenderId);
            if (_context.PokemonType.Any(e => e.PokemonsId == id))
            {
                ViewBag.PokemonTypes = _context.PokemonType.Where(e => e.PokemonsId == id).ToList();
            }
            return View(pokemons);
        }

        // POST: Admin/Pokemon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Number,Name,url,GenderId,Generation,ColorId,HP,Attack,Special_Attack,Defense,Special_Defense,Speed")] Pokemon.Models.Pokemon pokemons, int[] poketype)
        {
            if (id != pokemons.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    foreach (var pok in _context.PokemonType)
                    {
                        if (pok.PokemonsId == pokemons.Id)
                        {
                            _context.Update(pok);
                        }
                    }
                    foreach (int t in poketype)
                    {
                        PokemonType pok = _context.PokemonType.FirstOrDefault(x => x.PokeTypeId == t & x.PokemonsId == pokemons.Id);
                        if (pok != null)
                        {
                            _context.Update(pok);
                        }
                        else
                        {
                            _context.Add(new PokemonType { PokeTypeId = t, PokemonsId = pokemons.Id });
                        }
                    }

                    var n = pokemons.Number;
                    if (n <= 151)
                    {
                        pokemons.Generation = 1;
                    }
                    else if (n <= 251)
                    {
                        pokemons.Generation = 2;
                    }
                    else if (n <= 386)
                    {
                        pokemons.Generation = 3;
                    }
                    else if (n <= 493)
                    {
                        pokemons.Generation = 4;
                    }
                    else if (n <= 649)
                    {
                        pokemons.Generation = 5;
                    }
                    else if (n <= 721)
                    {
                        pokemons.Generation = 6;
                    }
                    else if (n <= 809)
                    {
                        pokemons.Generation = 7;
                    }
                    else
                    {
                        pokemons.Generation = 8;
                    }

                    var number = "0";
                    if (pokemons.Number < 10)
                    {
                        number = "00" + pokemons.Number;
                        pokemons.url = number + ".png";
                    }
                    else if (pokemons.Number < 100)
                    {
                        number = "0" + pokemons.Number;
                        pokemons.url = number + ".png";
                    }
                    else
                    {
                        pokemons.url = pokemons.Number + ".png";
                    }

                    _context.Update(pokemons);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokemonsExists(pokemons.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pokemons);
        }

        // GET: Admin/Pokemon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemons = await _context.Pokemon
                .Include(p => p.Color)
                .Include(p => p.Gender)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pokemons == null)
            {
                return NotFound();
            }

            return View(pokemons);
        }

        // POST: Admin/Pokemon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pokemons = await _context.Pokemon.FindAsync(id);
            _context.Pokemon.Remove(pokemons);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokemonsExists(int id)
        {
            return _context.Pokemon.Any(e => e.Id == id);
        }
    }
}
