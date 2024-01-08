using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class Sczepienie
    {
        public decimal SzczepienieId { get; set; }
        public decimal? PiesId { get; set; }
        public string SzczepienieRodzaj { get; set; } = null!;
        public DateTime SzczepienieData { get; set; }
        public DateTime? SzczepienieWaznosc { get; set; }

        public virtual Pies? Pies { get; set; }
    }
}
