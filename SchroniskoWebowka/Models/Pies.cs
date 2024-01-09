using System;
using System.Collections.Generic;

namespace SchroniskoWebowka.Models
{
    public partial class Pies
    {
        public Pies()
        {
            HistoriaAdopcjis = new HashSet<HistoriaAdopcji>();
            HistoriaLeczenia = new HashSet<HistoriaLeczenium>();
            Lekis = new HashSet<Leki>();
            Sczepienies = new HashSet<Sczepienie>();
            DocelowaGrupas = new HashSet<DocelowaGrupa>();
            Przypisanies = new HashSet<Przypisanie>();
        }

        public decimal PiesId { get; set; }
        public decimal StrefaId { get; set; }
        public decimal? CharakterId { get; set; }
        public decimal RasaId { get; set; }
        public decimal WiekId { get; set; }
        public string? PiesNazwa { get; set; }
        public bool PiesCzySuka { get; set; }
        public DateTime? PiesDataUrodzenia { get; set; }
        public byte[]? PiesZdjecie { get; set; }
        public bool PiesCzyDostepny { get; set; }
        public string? PiesKolorWzorSiersci { get; set; }
        public string? PiesOpis { get; set; }

        public virtual Charakter? Charakter { get; set; }
        public virtual Rasa Rasa { get; set; } = null!;
        public virtual Strefa Strefa { get; set; } = null!;
        public virtual Wiek Wiek { get; set; } = null!;
        public virtual ICollection<HistoriaAdopcji> HistoriaAdopcjis { get; set; }
        public virtual ICollection<HistoriaLeczenium> HistoriaLeczenia { get; set; }
        public virtual ICollection<Leki> Lekis { get; set; }
        public virtual ICollection<Sczepienie> Sczepienies { get; set; }

        public virtual ICollection<DocelowaGrupa> DocelowaGrupas { get; set; }
        public virtual ICollection<Przypisanie> Przypisanies { get; set; }
    }
}
