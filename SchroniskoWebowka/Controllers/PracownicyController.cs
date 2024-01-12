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
            return RedirectToAction("Index");
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
                return await Task.Run(() => View("View", viewModel));
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdatePracownikViewModel model, bool IsActive)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var pracownik = await _context.Pracowniks.FirstOrDefaultAsync(x => x.PracownikId == model.PracownikId);
            if (pracownik != null)
            {
                pracownik.PracownikImie = model.PracownikImie;
                pracownik.PracownikNazwisko = model.PracownikNazwisko;
                pracownik.PracownikDataZatrudnienia = model.PracownikDataZatrudnienia;
                pracownik.PracownikDataZwolnienia = model.PracownikDataZwolnienia;
                pracownik.PracownikMiesjcowosc = model.PracownikMiesjcowosc;
                pracownik.PracownikUlica = model.PracownikUlica;
                pracownik.PracownikNrBudynku = model.PracownikNrBudynku;
                pracownik.PracownikNrMieszkania = model.PracownikNrMieszkania;
                pracownik.PracownikNumerTelefonu = model.PracownikNumerTelefonu;
                pracownik.PracownikEmail = model.PracownikEmail;
                pracownik.PracownikCzyAdmin = IsActive;
                pracownik.PracownikHaslo = model.PracownikHaslo;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdatePracownikViewModel model)
        {
            var pracownik = await _context.Pracowniks.FindAsync(model.PracownikId);
            if (pracownik != null)
            {
                _context.Pracowniks.Remove(pracownik);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
