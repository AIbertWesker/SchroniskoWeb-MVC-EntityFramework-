using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class StatusPrzypisanium
    {
        public StatusPrzypisanium()
        {
            Przypisanies = new HashSet<Przypisanie>();
        }

        public decimal StatusPrzypisaniaId { get; set; }
        public string StatusPrzypisaniaNazwa { get; set; } = null!;

        public virtual ICollection<Przypisanie> Przypisanies { get; set; }
    }
}
