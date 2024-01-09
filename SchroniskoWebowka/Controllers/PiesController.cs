using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchroniskoWebowka.Models;

namespace SchroniskoWebowka.Controllers
{
    public class PiesController : Controller
    {
        private readonly SchroniskoContext _context;

        public PiesController(SchroniskoContext context)
        {
            _context = context;
        }

        // GET: Pies
        public async Task<IActionResult> Index()
        {
            var schroniskoContext = _context.Pies.Include(p => p.Charakter).Include(p => p.Rasa).Include(p => p.Strefa).Include(p => p.Wiek);
            return View(await schroniskoContext.ToListAsync());
        }

        // GET: Pies/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null || _context.Pies == null)
            {
                return NotFound();
            }

            var pies = await _context.Pies
                .Include(p => p.Charakter)
                .Include(p => p.Rasa)
                .Include(p => p.Strefa)
                .Include(p => p.Wiek)
                .FirstOrDefaultAsync(m => m.PiesId == id);
            if (pies == null)
            {
                return NotFound();
            }

            return View(pies);
        }

        // GET: Pies/Create
        public IActionResult Create()
        {
            ViewData["CharakterId"] = new SelectList(_context.Charakters, "CharakterId", "CharakterNazwa");
            ViewData["RasaId"] = new SelectList(_context.Rasas, "RasaId", "RasaNazwa");
            ViewData["StrefaId"] = new SelectList(_context.Strefas, "StrefaId", "StrefaNazwa");
            ViewData["WiekId"] = new SelectList(_context.Wieks, "WiekId", "WiekNazwa");
            return View();
        }

        // POST: Pies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PiesId,StrefaId,CharakterId,RasaId,WiekId,PiesNazwa,PiesCzySuka,PiesDataUrodzenia,PiesZdjecie,PiesCzyDostepny,PiesKolorWzorSiersci,PiesOpis")] Pies pies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CharakterId"] = new SelectList(_context.Charakters, "CharakterId", "CharakterNazwa", pies.CharakterId);
            ViewData["RasaId"] = new SelectList(_context.Rasas, "RasaId", "RasaNazwa", pies.RasaId);
            ViewData["StrefaId"] = new SelectList(_context.Strefas, "StrefaId", "StrefaNazwa", pies.StrefaId);
            ViewData["WiekId"] = new SelectList(_context.Wieks, "WiekId", "WiekNazwa", pies.WiekId);
            return View(pies);
        }

        // GET: Pies/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null || _context.Pies == null)
            {
                return NotFound();
            }

            var pies = await _context.Pies.FindAsync(id);
            if (pies == null)
            {
                return NotFound();
            }
            ViewData["CharakterId"] = new SelectList(_context.Charakters, "CharakterId", "CharakterId", pies.CharakterId);
            ViewData["RasaId"] = new SelectList(_context.Rasas, "RasaId", "RasaId", pies.RasaId);
            ViewData["StrefaId"] = new SelectList(_context.Strefas, "StrefaId", "StrefaId", pies.StrefaId);
            ViewData["WiekId"] = new SelectList(_context.Wieks, "WiekId", "WiekId", pies.WiekId);
            return View(pies);
        }

        // POST: Pies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("PiesId,StrefaId,CharakterId,RasaId,WiekId,PiesNazwa,PiesCzySuka,PiesDataUrodzenia,PiesZdjecie,PiesCzyDostepny,PiesKolorWzorSiersci,PiesOpis")] Pies pies)
        {
            if (id != pies.PiesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PiesExists(pies.PiesId))
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
            ViewData["CharakterId"] = new SelectList(_context.Charakters, "CharakterId", "CharakterId", pies.CharakterId);
            ViewData["RasaId"] = new SelectList(_context.Rasas, "RasaId", "RasaId", pies.RasaId);
            ViewData["StrefaId"] = new SelectList(_context.Strefas, "StrefaId", "StrefaId", pies.StrefaId);
            ViewData["WiekId"] = new SelectList(_context.Wieks, "WiekId", "WiekId", pies.WiekId);
            return View(pies);
        }

        // GET: Pies/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null || _context.Pies == null)
            {
                return NotFound();
            }

            var pies = await _context.Pies
                .Include(p => p.Charakter)
                .Include(p => p.Rasa)
                .Include(p => p.Strefa)
                .Include(p => p.Wiek)
                .FirstOrDefaultAsync(m => m.PiesId == id);
            if (pies == null)
            {
                return NotFound();
            }

            return View(pies);
        }

        // POST: Pies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            if (_context.Pies == null)
            {
                return Problem("Entity set 'SchroniskoContext.Pies'  is null.");
            }
            var pies = await _context.Pies.FindAsync(id);
            if (pies != null)
            {
                _context.Pies.Remove(pies);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PiesExists(decimal id)
        {
            return (_context.Pies?.Any(e => e.PiesId == id)).GetValueOrDefault();
        }
    }
}
