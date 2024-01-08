using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class StatusAdopcji
    {
        public StatusAdopcji()
        {
            HistoriaAdopcjis = new HashSet<HistoriaAdopcji>();
        }

        public decimal StatusAdopcjiId { get; set; }
        public string StatusAdopcjiNazwa { get; set; } = null!;

        public virtual ICollection<HistoriaAdopcji> HistoriaAdopcjis { get; set; }
    }
}
