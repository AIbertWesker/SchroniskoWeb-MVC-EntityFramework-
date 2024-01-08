using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class Charakter
    {
        public Charakter()
        {
            Pies = new HashSet<Pies>();
        }

        public decimal CharakterId { get; set; }
        public string CharakterNazwa { get; set; } = null!;

        public virtual ICollection<Pies> Pies { get; set; }
    }
}
