using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class HistoriaAdopcji
    {
        public decimal HistoriaAdopicjiId { get; set; }
        public decimal StatusAdopcjiId { get; set; }
        public decimal? PiesId { get; set; }
        public decimal AdoptujacyId { get; set; }
        public DateTime HistoriaAdopicjiData { get; set; }
        public decimal? HistoriaAdopicjiOplata { get; set; }

        public virtual Adoptujacy Adoptujacy { get; set; } = null!;
        public virtual Pies? Pies { get; set; }
        public virtual StatusAdopcji StatusAdopcji { get; set; } = null!;
    }
}
