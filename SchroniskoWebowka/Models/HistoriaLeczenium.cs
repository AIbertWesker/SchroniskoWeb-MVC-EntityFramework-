using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class HistoriaLeczenium
    {
        public decimal HistoriaLeczeniaId { get; set; }
        public decimal? PiesId { get; set; }
        public DateTime HistoriaLeczeniaData { get; set; }
        public string HistoriaLeczeniaNaglowek { get; set; } = null!;
        public string? HistoriaLeczeniaOpis { get; set; }

        public virtual Pies? Pies { get; set; }
    }
}
