namespace SchroniskoWebowka.Models
{
    public class AddPracownikViewModel
    {
        public int RasaId { get; set; }
        public string PracownikImie { get; set; } = null!;
        public string PracownikNazwisko { get; set; } = null!;
        public DateTime PracownikDataZatrudnienia { get; set; }
        public DateTime? PracownikDataZwolnienia { get; set; }
        public string PracownikMiesjcowosc { get; set; } = null!;
        public string PracownikUlica { get; set; } = null!;
        public int PracownikNrBudynku { get; set; }
        public int? PracownikNrMieszkania { get; set; }
        public string? PracownikNumerTelefonu { get; set; }
        public string? PracownikEmail { get; set; }
        public bool? PracownikCzyAdmin { get; set; }
        public string PracownikHaslo { get; set; } = null!;
    }
}
