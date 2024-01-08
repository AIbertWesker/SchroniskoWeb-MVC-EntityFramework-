using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class Przypisanie
    {
        public Przypisanie()
        {
            Pies = new HashSet<Pies>();
            Pracowniks = new HashSet<Pracownik>();
        }

        public decimal PrzypisanieId { get; set; }
        public decimal StatusPrzypisaniaId { get; set; }
        public DateTime PrzypisanieDataRozpoczecia { get; set; }
        public DateTime? PrzypisanieDataZakonczenia { get; set; }

        public virtual StatusPrzypisanium StatusPrzypisania { get; set; } = null!;

        public virtual ICollection<Pies> Pies { get; set; }
        public virtual ICollection<Pracownik> Pracowniks { get; set; }
    }
}
