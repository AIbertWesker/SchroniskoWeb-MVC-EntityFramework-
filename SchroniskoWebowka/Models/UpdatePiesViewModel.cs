namespace SchroniskoWebowka.Models
{
	public class UpdatePiesViewModel
	{
        public decimal PiesId { get; set; }
        public decimal StrefaId { get; set; }
        public decimal? CharakterId { get; set; }
        public decimal RasaId { get; set; }
        public decimal WiekId { get; set; }
        public string? PiesNazwa { get; set; }
        public bool PiesCzySuka { get; set; }
        public DateTime? PiesDataUrodzenia { get; set; }
        public byte[]? PiesZdjecie { get; set; }
        public bool PiesCzyDostepny { get; set; }
        public string? PiesKolorWzorSiersci { get; set; }
        public string? PiesOpis { get; set; }
    }
}
