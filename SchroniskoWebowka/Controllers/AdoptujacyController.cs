using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchroniskoWebowka.Models;

namespace SchroniskoWebowka.Controllers
{
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
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var schroniskoContext = _context.Adoptujacies.Include(p => p.Zaufanie);
            return View(await schroniskoContext.ToListAsync());
        }
    }
}
