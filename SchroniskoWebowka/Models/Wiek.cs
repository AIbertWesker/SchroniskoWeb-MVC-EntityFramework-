using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class Wiek
    {
        public Wiek()
        {
            Pies = new HashSet<Pies>();
        }

        public decimal WiekId { get; set; }
        public string WiekNazwa { get; set; } = null!;

        public virtual ICollection<Pies> Pies { get; set; }
    }
}
