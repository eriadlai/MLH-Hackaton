using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarketUtilities_V2.Data;
using MarketUtilities_V2.Models;

namespace MarketUtilities_V2.Controllers
{
    public class PasilloesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PasilloesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pasilloes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Pasillo.ToListAsync());
        }

        // GET: Pasilloes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pasillo == null)
            {
                return NotFound();
            }

            var pasillo = await _context.Pasillo
                .FirstOrDefaultAsync(m => m.id == id);
            if (pasillo == null)
            {
                return NotFound();
            }

            return View(pasillo);
        }

        // GET: Pasilloes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pasilloes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,modified_by,created_by,moified_date")] Pasillo pasillo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pasillo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pasillo);
        }

        // GET: Pasilloes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pasillo == null)
            {
                return NotFound();
            }

            var pasillo = await _context.Pasillo.FindAsync(id);
            if (pasillo == null)
            {
                return NotFound();
            }
            return View(pasillo);
        }

        // POST: Pasilloes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre,modified_by,created_by,moified_date")] Pasillo pasillo)
        {
            if (id != pasillo.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pasillo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PasilloExists(pasillo.id))
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
            return View(pasillo);
        }

        // GET: Pasilloes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pasillo == null)
            {
                return NotFound();
            }

            var pasillo = await _context.Pasillo
                .FirstOrDefaultAsync(m => m.id == id);
            if (pasillo == null)
            {
                return NotFound();
            }

            return View(pasillo);
        }

        // POST: Pasilloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pasillo == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Pasillo'  is null.");
            }
            var pasillo = await _context.Pasillo.FindAsync(id);
            if (pasillo != null)
            {
                _context.Pasillo.Remove(pasillo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PasilloExists(int id)
        {
          return _context.Pasillo.Any(e => e.id == id);
        }
    }
}
