using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchroniskoWebowka.Models;

namespace SchroniskoWebowka.Controllers
{
    public class PsyController : Controller
    {
        private readonly SchroniskoContext _context;
        public PsyController(SchroniskoContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
			var schroniskoContext = _context.Pies.Include(p => p.Charakter).Include(p => p.Rasa).Include(p => p.Strefa).Include(p => p.Wiek);
			return View(await schroniskoContext.ToListAsync());
		}

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Strefa = new SelectList(_context.Strefas, "StrefaId", "StrefaNazwa");
            ViewBag.Rasa = new SelectList(_context.Rasas, "RasaId", "RasaNazwa");
            ViewBag.Charakter = new SelectList(_context.Charakters, "CharakterId", "CharakterNazwa");
            ViewBag.Wiek = new SelectList(_context.Wieks, "WiekId", "WiekNazwa");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddPiesViewModel model, IFormCollection form)
        {
            if (!ModelState.IsValid)
                {
                    return View(model);
                }
            int wybranaStrefaId = int.Parse(form["WybranaStrefa"]);
            int wybranaRasaId = int.Parse(form["WybranaRasa"]);
            int wybranyCharakterId = int.Parse(form["WybranyCharakter"]);
            int wybranyWiekId = int.Parse(form["WybranyWiek"]);
            var pies = new Pies
                {
                    StrefaId = wybranaStrefaId,
                    CharakterId = wybranyCharakterId,
                    RasaId = wybranaRasaId,
                    WiekId = wybranyWiekId,
                    PiesNazwa = model.PiesNazwa,
                    PiesCzySuka = model.PiesCzySuka,
                    PiesDataUrodzenia = model.PiesDataUrodzenia,
                    PiesZdjecie = model.PiesZdjecie,
                    PiesCzyDostepny = model.PiesCzyDostepny,
                    PiesKolorWzorSiersci = model.PiesKolorWzorSiersci,
                    PiesOpis = model.PiesOpis
                };
                await _context.Pies.AddAsync(pies);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
        }


    }
}
