using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class Strefa
    {
        public Strefa()
        {
            Pies = new HashSet<Pies>();
        }

        public decimal StrefaId { get; set; }
        public string StrefaNazwa { get; set; } = null!;

        public virtual ICollection<Pies> Pies { get; set; }
    }
}
