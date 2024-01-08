using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class DocelowaGrupa
    {
        public DocelowaGrupa()
        {
            Pies = new HashSet<Pies>();
        }

        public decimal DocelowaGrupaId { get; set; }
        public string DocelowaGrupaNazwa { get; set; } = null!;

        public virtual ICollection<Pies> Pies { get; set; }
    }
}
