using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchroniskoWebowka.Models;

namespace SchroniskoWebowka.Controllers
{
    [Authorize]
    public class AdoptujacyController : Controller
    {

        private readonly SchroniskoContext _context;
        public AdoptujacyController(SchroniskoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Zaufanie = new SelectList(_context.Zaufanies, "ZaufanieId", "ZaufanieNazwa");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddAdoptujacyViewModel model, IFormCollection form)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            int wybranaZaufanieId = int.Parse(form["WybraneZaufanie"]);

            var adoptujacy = new Adoptujacy()
            {
                ZaufanieId = wybranaZaufanieId,
                AdoptujacyImie = model.AdoptujacyImie,
                AdoptujacyNazwisko = model.AdoptujacyNazwisko,
                AdoptujacyCzyKobieta = model.AdoptujacyCzyKobieta,
                AdoptujacyMiejscowosc = model.AdoptujacyMiejscowosc,
                AdoptujacyUlica = model.AdoptujacyUlica,
                AdoptujacyNrBudynku = model.AdoptujacyNrBudynku,
                AdoptujacyNrMieszkania = model.AdoptujacyNrMieszkania,
                AdoptujacyTelefon = model.AdoptujacyTelefon

            };
            await _context.Adoptujacies.AddAsync(adoptujacy);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var schroniskoContext = _context.Adoptujacies.Include(p => p.Zaufanie);
            return View(await schroniskoContext.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Edit(decimal id)
        {
            var adopt = await _context.Adoptujacies.FirstOrDefaultAsync(x => x.AdoptujacyId == id);
            if (adopt != null)
            {
                var viewModel = new UpdateAdoptujacyViewModel
                {
                    ZaufanieId = adopt.ZaufanieId,
                    AdoptujacyId = adopt.AdoptujacyId,
                    AdoptujacyImie = adopt.AdoptujacyImie,
                    AdoptujacyNazwisko = adopt.AdoptujacyNazwisko,
                    AdoptujacyCzyKobieta = adopt.AdoptujacyCzyKobieta,
                    AdoptujacyMiejscowosc = adopt.AdoptujacyMiejscowosc,
                    AdoptujacyUlica = adopt.AdoptujacyUlica,
                    AdoptujacyNrBudynku = adopt.AdoptujacyNrBudynku,
                    AdoptujacyNrMieszkania = adopt.AdoptujacyNrMieszkania,
                    AdoptujacyTelefon = adopt.AdoptujacyTelefon
                };
                ViewBag.Zaufanie = new SelectList(_context.Zaufanies, "ZaufanieId", "ZaufanieNazwa");

                return await Task.Run(() => View("Edit", viewModel));
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateAdoptujacyViewModel model)
        {
            var adoptToUpdate = await _context.Adoptujacies.FirstOrDefaultAsync(x => x.AdoptujacyId == model.AdoptujacyId);

            if (adoptToUpdate != null)
            {
                adoptToUpdate.AdoptujacyImie = model.AdoptujacyImie;
                adoptToUpdate.AdoptujacyNazwisko = model.AdoptujacyNazwisko;
                adoptToUpdate.AdoptujacyCzyKobieta = model.AdoptujacyCzyKobieta;
                adoptToUpdate.AdoptujacyMiejscowosc = model.AdoptujacyMiejscowosc;
                adoptToUpdate.AdoptujacyUlica = model.AdoptujacyUlica;
                adoptToUpdate.AdoptujacyNrBudynku = model.AdoptujacyNrBudynku;
                adoptToUpdate.AdoptujacyNrMieszkania = model.AdoptujacyNrMieszkania;
                adoptToUpdate.AdoptujacyTelefon = model.AdoptujacyTelefon;
                adoptToUpdate.ZaufanieId = model.ZaufanieId;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateAdoptujacyViewModel model)
        {
            var adopt = await _context.Adoptujacies.FindAsync(model.AdoptujacyId);
            if (adopt != null)
            {
                _context.Adoptujacies.Remove(adopt);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
