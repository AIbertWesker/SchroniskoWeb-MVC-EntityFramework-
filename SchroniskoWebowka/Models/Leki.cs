using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class Leki
    {
        public decimal LekId { get; set; }
        public decimal? PiesId { get; set; }
        public string LekNazwa { get; set; } = null!;
        public short LekDawka { get; set; }
        public string LekCzestotliwosc { get; set; } = null!;
        public DateTime LekDataRozpoczecia { get; set; }
        public DateTime? LekDataZakonczenia { get; set; }
        public string? LekOpis { get; set; }

        public virtual Pies? Pies { get; set; }
    }
}
