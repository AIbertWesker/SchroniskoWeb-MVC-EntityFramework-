using Microsoft.AspNetCore.Mvc.Rendering;

namespace SchroniskoWebowka.Models
{
    public class AddAdoptujacyViewModel
    {
        public decimal? ZaufanieId { get; set; }
        public string AdoptujacyImie { get; set; } = null!;
        public string AdoptujacyNazwisko { get; set; } = null!;
        public bool? AdoptujacyCzyKobieta { get; set; }
        public string AdoptujacyMiejscowosc { get; set; } = null!;
        public string AdoptujacyUlica { get; set; } = null!;
        public int AdoptujacyNrBudynku { get; set; }
        public int? AdoptujacyNrMieszkania { get; set; }
        public string? AdoptujacyTelefon { get; set; }
    }
}
