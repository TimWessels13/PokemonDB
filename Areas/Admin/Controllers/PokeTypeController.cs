using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pokemon.Data;
using Pokemon.Models;

namespace Pokemon_DB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PokeTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PokeTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/PokeType
        public async Task<IActionResult> Index()
        {
            return View(await _context.PokeType.OrderBy(p => p.Name).ToListAsync());
        }

        // GET: Admin/PokeType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokeType = await _context.PokeType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pokeType == null)
            {
                return NotFound();
            }

            return View(pokeType);
        }

        // GET: Admin/PokeType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PokeType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Image,ImageFileName")] PokeType pokeType, IFormFile imageUpload)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pokeType);
                await _context.SaveChangesAsync();

                var fileExtension = Path.GetExtension(imageUpload.FileName);
                var filePath = Url.Content("wwwroot/uploads/images/types/" + pokeType.Name + fileExtension);
                if (imageUpload.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageUpload.CopyToAsync(stream);
                        pokeType.ImageFileName = pokeType.Name + fileExtension;
                    }
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pokeType);
        }

        // GET: Admin/PokeType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokeType = await _context.PokeType.FindAsync(id);
            if (pokeType == null)
            {
                return NotFound();
            }
            return View(pokeType);
        }

        // POST: Admin/PokeType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Image,ImageFileName")] PokeType pokeType, IFormFile imageUpload)
        {
            var fileExtension = Path.GetExtension(imageUpload.FileName);
            var filePath = Url.Content("wwwroot/uploads/images/types/" + pokeType.Name + fileExtension);
            if (imageUpload.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageUpload.CopyToAsync(stream);
                    pokeType.ImageFileName = pokeType.Name + fileExtension;
                }
            }

            if (id != pokeType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pokeType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokeTypeExists(pokeType.Id))
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
            return View(pokeType);
        }

        // GET: Admin/PokeType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokeType = await _context.PokeType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pokeType == null)
            {
                return NotFound();
            }

            return View(pokeType);
        }

        // POST: Admin/PokeType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pokeType = await _context.PokeType.FindAsync(id);
            _context.PokeType.Remove(pokeType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokeTypeExists(int id)
        {
            return _context.PokeType.Any(e => e.Id == id);
        }
    }
}
