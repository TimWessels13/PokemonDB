using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pokemon.Data;
using Pokemon.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon_Database.Controllers
{
    public class GoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Go
        public async Task<IActionResult> Index(string searchString)
        {
            GoView go = new GoView();
            go.Go = _context.Go.ToList();
            go.Pokemon = _context.Pokemon.OrderBy(p => p.Number).ToList();
            go.PokeType = _context.PokeType.ToList();
            go.PokemonType = _context.PokemonType.ToList();
            go.Color = _context.Color.ToList();
            go.Gender = _context.Gender.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                go.Pokemon = go.Pokemon.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
            }

            return View(go);
        }

        // GET: Go/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var go = await _context.Go
                .Include(g => g.Pokemon)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (go == null)
            {
                return NotFound();
            }

            return View(go);
        }

        // GET: Go/Create
        public IActionResult Create()
        {
            ViewData["PokemonsId"] = new SelectList(_context.Pokemon, "Id", "Name");
            return View();
        }

        // POST: Go/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PokemonsId,Seen,Caught,Lucky,Shiny,Shadow")] Go go)
        {
            if (ModelState.IsValid)
            {
                _context.Add(go);

                var check = _context.Go.FirstOrDefault(w => w.PokemonsId == go.PokemonsId);
                if (check == null)
                {
                    if (go.Seen >= go.Caught)
                    {
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        //doe niets
                    }
                }
                else
                {
                    //doe niets
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PokemonsId"] = new SelectList(_context.Pokemon, "Id", "Name", go.PokemonsId);
            return View(go);
        }

        // GET: Go/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var go = await _context.Go.FindAsync(id);
            if (go == null)
            {
                return NotFound();
            }
            ViewData["PokemonsId"] = new SelectList(_context.Pokemon, "Id", "Name", go.PokemonsId);
            return View(go);
        }

        // POST: Go/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PokemonsId,Seen,Caught,Lucky,Shiny,Shadow")] Go go)
        {
            if (id != go.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(go);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoExists(go.Id))
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
            ViewData["PokemonsId"] = new SelectList(_context.Pokemon, "Id", "Name", go.PokemonsId);
            return View(go);
        }

        // GET: Go/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var go = await _context.Go
                .Include(g => g.Pokemon)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (go == null)
            {
                return NotFound();
            }

            return View(go);
        }

        // POST: Go/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var go = await _context.Go.FindAsync(id);
            _context.Go.Remove(go);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoExists(int id)
        {
            return _context.Go.Any(e => e.Id == id);
        }
    }
}
