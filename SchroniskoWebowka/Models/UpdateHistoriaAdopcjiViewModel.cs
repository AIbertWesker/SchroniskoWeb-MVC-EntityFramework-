namespace SchroniskoWebowka.Models
{
    public class UpdateHistoriaAdopcjiViewModel
    {
        public decimal HistoriaAdopicjiId { get; set; }
        public decimal StatusAdopcjiId { get; set; }
        public decimal? PiesId { get; set; }
        public decimal AdoptujacyId { get; set; }
        public DateTime HistoriaAdopicjiData { get; set; }
        public decimal? HistoriaAdopicjiOplata { get; set; }
    }
}
