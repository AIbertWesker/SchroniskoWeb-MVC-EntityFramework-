using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchroniskoWebowka.Models;

namespace SchroniskoWebowka.Controllers
{
    public class PracownicyController : Controller
    {
        private readonly SchroniskoContext _context;
        public PracownicyController(SchroniskoContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Add()
        {
            var rasy = _context.Rasas.ToList();
            ViewBag.data = rasy;

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var pracowniki = await _context.Pracowniks.ToListAsync();
            return View(pracowniki);
        } 

        [HttpPost]
        public async Task<IActionResult> Add(AddPracownikViewModel model, bool IsActive)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var pracownik = new Pracownik
            {
                PracownikImie = model.PracownikImie,
                PracownikNazwisko = model.PracownikNazwisko,
                PracownikDataZatrudnienia = model.PracownikDataZatrudnienia,
                PracownikDataZwolnienia = model.PracownikDataZwolnienia,
                PracownikMiesjcowosc = model.PracownikMiesjcowosc,
                PracownikUlica = model.PracownikUlica,
                PracownikNrBudynku = model.PracownikNrBudynku,
                PracownikNrMieszkania = model.PracownikNrMieszkania,
                PracownikNumerTelefonu = model.PracownikNumerTelefonu,
                PracownikEmail = model.PracownikEmail,
                PracownikCzyAdmin = IsActive,
                PracownikHaslo = model.PracownikHaslo
            };
            await _context.Pracowniks.AddAsync(pracownik);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> View(decimal id)
        {
            var pracownik = await _context.Pracowniks.FirstOrDefaultAsync(x => x.PracownikId == id);

            if (pracownik != null)
            {
                var viewModel = new UpdatePracownikViewModel()
                {
                    PracownikId = pracownik.PracownikId,
                    PracownikImie = pracownik.PracownikImie,
                    PracownikNazwisko = pracownik.PracownikNazwisko,
                    PracownikDataZatrudnienia = pracownik.PracownikDataZatrudnienia,
                    PracownikDataZwolnienia = pracownik.PracownikDataZwolnienia,
                    PracownikMiesjcowosc = pracownik.PracownikMiesjcowosc,
                    PracownikUlica = pracownik.PracownikUlica,
                    PracownikNrBudynku = pracownik.PracownikNrBudynku,
                    PracownikNrMieszkania = pracownik.PracownikNrMieszkania,
                    PracownikNumerTelefonu = pracownik.PracownikNumerTelefonu,
                    PracownikEmail = pracownik.PracownikEmail,
                    PracownikCzyAdmin = pracownik.PracownikCzyAdmin,
                    PracownikHaslo = pracownik.PracownikHaslo
                };
                return View(viewModel);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
