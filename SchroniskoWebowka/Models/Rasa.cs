using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class Rasa
    {
        public Rasa()
        {
            Pies = new HashSet<Pies>();
        }

        public decimal RasaId { get; set; }
        public string RasaNazwa { get; set; } = null!;

        public virtual ICollection<Pies> Pies { get; set; }
    }
}
