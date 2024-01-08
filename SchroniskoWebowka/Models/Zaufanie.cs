using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class Zaufanie
    {
        public Zaufanie()
        {
            Adoptujacies = new HashSet<Adoptujacy>();
        }

        public decimal ZaufanieId { get; set; }
        public string ZaufanieNazwa { get; set; } = null!;

        public virtual ICollection<Adoptujacy> Adoptujacies { get; set; }
    }
}
