using Microsoft.AspNetCore.Mvc.Rendering;

namespace SchroniskoWebowka.Models
{
	public class AddHistoriaAdopcjiViewModel
	{
		public decimal StatusAdopcjiId { get; set; }
		public decimal? PiesId { get; set; }
		public decimal AdoptujacyId { get; set; }
		public DateTime HistoriaAdopicjiData { get; set; }
		public decimal? HistoriaAdopicjiOplata { get; set; }
    }
}
