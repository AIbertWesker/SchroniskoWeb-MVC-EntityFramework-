using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchroniskoWebowka.Models;
using SchroniskoWebowka.Models.AdvanceComboBoxs;

namespace SchroniskoWebowka.Controllers
{
    [Authorize]
    public class HistoriaAdopcjiController : Controller
    {
        private readonly SchroniskoContext _context;
        public HistoriaAdopcjiController(SchroniskoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var piesRasy = _context.Pies
                .Include(p => p.Rasa)
                .Where(p => p.PiesCzyDostepny)
                .Select(p => new
                {
                    PiesId = p.PiesId,
                    Nazwa = $"{(!string.IsNullOrEmpty(p.PiesNazwa) ? p.PiesNazwa : "Brak Nazwy")} - {p.Rasa.RasaNazwa}"
                })
                .ToList();

            var adoptujacy = _context.Adoptujacies
                .Select(a => new
                {
                    AdoptujacyId = a.AdoptujacyId,
                    Nazwa = $"{a.AdoptujacyNazwisko} {a.AdoptujacyImie}"
                })
                .ToList();

            ViewBag.PiesRasy = new SelectList(piesRasy, "PiesId", "Nazwa");
            ViewBag.Adoptujacy = new SelectList(adoptujacy, "AdoptujacyId", "Nazwa");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddHistoriaAdopcjiViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var historiaAdopcji = new HistoriaAdopcji()
            {
                PiesId = model.PiesId,
                AdoptujacyId = model.AdoptujacyId,
                HistoriaAdopicjiData = model.HistoriaAdopicjiData,
                HistoriaAdopicjiOplata = model.HistoriaAdopicjiOplata,
                StatusAdopcjiId = 1
            };

            var piesToUpdate = await _context.Pies.FirstOrDefaultAsync(x => x.PiesId == model.PiesId);

            if (piesToUpdate != null)
            {

                piesToUpdate.PiesCzyDostepny = false;

                await _context.SaveChangesAsync();
            }

            await _context.HistoriaAdopcjis.AddAsync(historiaAdopcji);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var schroniskoContext = _context.HistoriaAdopcjis.Include(p => p.StatusAdopcji).Include(p => p.Adoptujacy).Include(p => p.Pies).Include(p => p.Pies.Rasa);
            return View(await schroniskoContext.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Edit(decimal id)
        {
            var adopt = await _context.HistoriaAdopcjis.FirstOrDefaultAsync(x => x.HistoriaAdopicjiId == id);
            if (adopt != null)
            {

                var piesRasy = _context.Pies
                    .Include(p => p.Rasa)
                    .Select(p => new
                    {
                        PiesId = p.PiesId,
                        Nazwa = $"{(!string.IsNullOrEmpty(p.PiesNazwa) ? p.PiesNazwa : "Brak Nazwy")} - {p.Rasa.RasaNazwa}"
                    })
                    .ToList();

                var adoptujacy = _context.Adoptujacies
                    .Where(a => a.AdoptujacyId == adopt.AdoptujacyId)
                    .Select(a => new
                    {
                        AdoptujacyId = a.AdoptujacyId,
                        Nazwa = $"{a.AdoptujacyNazwisko} {a.AdoptujacyImie}"
                    })
                    .ToList();

                var viewModel = new UpdateHistoriaAdopcjiViewModel
                {
                    HistoriaAdopicjiId = adopt.HistoriaAdopicjiId,
                    StatusAdopcjiId = adopt.StatusAdopcjiId,
                    PiesId = adopt.PiesId,
                    AdoptujacyId = adopt.AdoptujacyId,
                    HistoriaAdopicjiData = adopt.HistoriaAdopicjiData,
                    HistoriaAdopicjiOplata = adopt.HistoriaAdopicjiOplata
                };

                ViewBag.Adoptujacy = new SelectList(adoptujacy, "AdoptujacyId", "Nazwa");
                ViewBag.PiesRasy = new SelectList(piesRasy, "PiesId", "Nazwa");
                ViewBag.StatusAdopcji = new SelectList(_context.StatusAdopcjis, "StatusAdopcjiId", "StatusAdopcjiNazwa");

                return await Task.Run(() => View("Edit", viewModel));
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateHistoriaAdopcjiViewModel model)
        {
            var adoptToUpdate = await _context.HistoriaAdopcjis.FirstOrDefaultAsync(x => x.HistoriaAdopicjiId == model.HistoriaAdopicjiId);

            if (adoptToUpdate != null)
            {
                adoptToUpdate.HistoriaAdopicjiOplata = model.HistoriaAdopicjiOplata;
                adoptToUpdate.HistoriaAdopicjiData = model.HistoriaAdopicjiData;
                adoptToUpdate.StatusAdopcjiId = model.StatusAdopcjiId;

                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateHistoriaAdopcjiViewModel model)
        {
            var adopt = await _context.HistoriaAdopcjis.FindAsync(model.HistoriaAdopicjiId);
            if (adopt != null)
            {
                _context.HistoriaAdopcjis.Remove(adopt);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
