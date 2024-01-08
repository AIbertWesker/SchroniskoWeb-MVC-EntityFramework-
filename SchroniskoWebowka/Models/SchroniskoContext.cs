using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SchroniskoWebowka.Models
{
    public partial class SchroniskoContext : DbContext
    {
        public SchroniskoContext()
        {
        }

        public SchroniskoContext(DbContextOptions<SchroniskoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adoptujacy> Adoptujacies { get; set; } = null!;
        public virtual DbSet<Charakter> Charakters { get; set; } = null!;
        public virtual DbSet<DocelowaGrupa> DocelowaGrupas { get; set; } = null!;
        public virtual DbSet<HistoriaAdopcji> HistoriaAdopcjis { get; set; } = null!;
        public virtual DbSet<HistoriaLeczenium> HistoriaLeczenia { get; set; } = null!;
        public virtual DbSet<Leki> Lekis { get; set; } = null!;
        public virtual DbSet<Pracownik> Pracowniks { get; set; } = null!;
        public virtual DbSet<Przypisanie> Przypisanies { get; set; } = null!;
        public virtual DbSet<Pies> Pies { get; set; } = null!;
        public virtual DbSet<Rasa> Rasas { get; set; } = null!;
        public virtual DbSet<Sczepienie> Sczepienies { get; set; } = null!;
        public virtual DbSet<StatusAdopcji> StatusAdopcjis { get; set; } = null!;
        public virtual DbSet<StatusPrzypisanium> StatusPrzypisania { get; set; } = null!;
        public virtual DbSet<Strefa> Strefas { get; set; } = null!;
        public virtual DbSet<Wiek> Wieks { get; set; } = null!;
        public virtual DbSet<Zaufanie> Zaufanies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adoptujacy>(entity =>
            {
                entity.HasKey(e => e.AdoptujacyId)
                    .HasName("PK_ADOPTUJACY")
                    .IsClustered(false);

                entity.ToTable("Adoptujacy");

                entity.HasIndex(e => e.ZaufanieId, "Zaufanie_Do_Adoptujacego_FK");

                entity.Property(e => e.AdoptujacyId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Adoptujacy_Id");

                entity.Property(e => e.AdoptujacyCzyKobieta).HasColumnName("Adoptujacy_CzyKobieta");

                entity.Property(e => e.AdoptujacyImie)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Adoptujacy_Imie");

                entity.Property(e => e.AdoptujacyMiejscowosc)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Adoptujacy_Miejscowosc");

                entity.Property(e => e.AdoptujacyNazwisko)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Adoptujacy_Nazwisko");

                entity.Property(e => e.AdoptujacyNrBudynku).HasColumnName("Adoptujacy_NrBudynku");

                entity.Property(e => e.AdoptujacyNrMieszkania).HasColumnName("Adoptujacy_NrMieszkania");

                entity.Property(e => e.AdoptujacyTelefon)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Adoptujacy_Telefon");

                entity.Property(e => e.AdoptujacyUlica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Adoptujacy_Ulica");

                entity.Property(e => e.ZaufanieId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Zaufanie_Id");

                entity.HasOne(d => d.Zaufanie)
                    .WithMany(p => p.Adoptujacies)
                    .HasForeignKey(d => d.ZaufanieId)
                    .HasConstraintName("FK_ADOPTUJA_ZAUFANIE__ZAUFANIE");
            });

            modelBuilder.Entity<Charakter>(entity =>
            {
                entity.HasKey(e => e.CharakterId)
                    .HasName("PK_CHARAKTER")
                    .IsClustered(false);

                entity.ToTable("Charakter");

                entity.Property(e => e.CharakterId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Charakter_Id");

                entity.Property(e => e.CharakterNazwa)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Charakter_Nazwa");
            });

            modelBuilder.Entity<DocelowaGrupa>(entity =>
            {
                entity.HasKey(e => e.DocelowaGrupaId)
                    .HasName("PK_DOCELOWA_GRUPA")
                    .IsClustered(false);

                entity.ToTable("Docelowa_grupa");

                entity.Property(e => e.DocelowaGrupaId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DocelowaGrupa_Id");

                entity.Property(e => e.DocelowaGrupaNazwa)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DocelowaGrupa_Nazwa");
            });

            modelBuilder.Entity<HistoriaAdopcji>(entity =>
            {
                entity.HasKey(e => e.HistoriaAdopicjiId)
                    .HasName("PK_HISTORIA_ADOPCJI")
                    .IsClustered(false);

                entity.ToTable("Historia_Adopcji");

                entity.HasIndex(e => e.AdoptujacyId, "Adoptujacy_HistoriaAdopcji_FK");

                entity.HasIndex(e => e.PiesId, "HistorieAdopcji_Psow_FK");

                entity.HasIndex(e => e.StatusAdopcjiId, "Status_Historii_Adopcji_FK");

                entity.Property(e => e.HistoriaAdopicjiId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HistoriaAdopicji_Id");

                entity.Property(e => e.AdoptujacyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Adoptujacy_Id");

                entity.Property(e => e.HistoriaAdopicjiData)
                    .HasColumnType("datetime")
                    .HasColumnName("HistoriaAdopicji_Data");

                entity.Property(e => e.HistoriaAdopicjiOplata)
                    .HasColumnType("money")
                    .HasColumnName("HistoriaAdopicji_Oplata");

                entity.Property(e => e.PiesId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Pies_Id");

                entity.Property(e => e.StatusAdopcjiId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("StatusAdopcji_Id");

                entity.HasOne(d => d.Adoptujacy)
                    .WithMany(p => p.HistoriaAdopcjis)
                    .HasForeignKey(d => d.AdoptujacyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISTORIA_ADOPTUJAC_ADOPTUJA");

                entity.HasOne(d => d.Pies)
                    .WithMany(p => p.HistoriaAdopcjis)
                    .HasForeignKey(d => d.PiesId)
                    .HasConstraintName("FK_HISTORIA_HISTORIEA_PIES");

                entity.HasOne(d => d.StatusAdopcji)
                    .WithMany(p => p.HistoriaAdopcjis)
                    .HasForeignKey(d => d.StatusAdopcjiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISTORIA_STATUS_HI_STATUS_A");
            });

            modelBuilder.Entity<HistoriaLeczenium>(entity =>
            {
                entity.HasKey(e => e.HistoriaLeczeniaId)
                    .HasName("PK_HISTORIA_LECZENIA")
                    .IsClustered(false);

                entity.ToTable("Historia_Leczenia");

                entity.HasIndex(e => e.PiesId, "HistoriaLeczenia_Psow_FK");

                entity.Property(e => e.HistoriaLeczeniaId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HistoriaLeczenia_Id");

                entity.Property(e => e.HistoriaLeczeniaData)
                    .HasColumnType("datetime")
                    .HasColumnName("HistoriaLeczenia_Data");

                entity.Property(e => e.HistoriaLeczeniaNaglowek)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("HistoriaLeczenia_Naglowek");

                entity.Property(e => e.HistoriaLeczeniaOpis)
                    .HasColumnType("text")
                    .HasColumnName("HistoriaLeczenia_Opis");

                entity.Property(e => e.PiesId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Pies_Id");

                entity.HasOne(d => d.Pies)
                    .WithMany(p => p.HistoriaLeczenia)
                    .HasForeignKey(d => d.PiesId)
                    .HasConstraintName("FK_HISTORIA_HISTORIAL_PIES");
            });

            modelBuilder.Entity<Leki>(entity =>
            {
                entity.HasKey(e => e.LekId)
                    .HasName("PK_LEKI")
                    .IsClustered(false);

                entity.ToTable("Leki");

                entity.HasIndex(e => e.PiesId, "Leki_Psow_FK");

                entity.Property(e => e.LekId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Lek_Id");

                entity.Property(e => e.LekCzestotliwosc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Lek_Czestotliwosc");

                entity.Property(e => e.LekDataRozpoczecia)
                    .HasColumnType("datetime")
                    .HasColumnName("Lek_DataRozpoczecia");

                entity.Property(e => e.LekDataZakonczenia)
                    .HasColumnType("datetime")
                    .HasColumnName("Lek_DataZakonczenia");

                entity.Property(e => e.LekDawka).HasColumnName("Lek_Dawka");

                entity.Property(e => e.LekNazwa)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Lek_Nazwa");

                entity.Property(e => e.LekOpis)
                    .HasColumnType("text")
                    .HasColumnName("Lek_Opis");

                entity.Property(e => e.PiesId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Pies_Id");

                entity.HasOne(d => d.Pies)
                    .WithMany(p => p.Lekis)
                    .HasForeignKey(d => d.PiesId)
                    .HasConstraintName("FK_LEKI_LEKI_PSOW_PIES");
            });

            modelBuilder.Entity<Pracownik>(entity =>
            {
                entity.HasKey(e => e.PracownikId)
                    .HasName("PK_PRACOWNIK")
                    .IsClustered(false);

                entity.ToTable("Pracownik");

                entity.Property(e => e.PracownikId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Pracownik_Id");

                entity.Property(e => e.PracownikCzyAdmin).HasColumnName("Pracownik_CzyAdmin");

                entity.Property(e => e.PracownikDataZatrudnienia)
                    .HasColumnType("datetime")
                    .HasColumnName("Pracownik_DataZatrudnienia");

                entity.Property(e => e.PracownikDataZwolnienia)
                    .HasColumnType("datetime")
                    .HasColumnName("Pracownik_DataZwolnienia");

                entity.Property(e => e.PracownikEmail)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Pracownik_Email");

                entity.Property(e => e.PracownikHaslo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Pracownik_Haslo")
                    .IsFixedLength();

                entity.Property(e => e.PracownikImie)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Pracownik_Imie");

                entity.Property(e => e.PracownikMiesjcowosc)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Pracownik_Miesjcowosc");

                entity.Property(e => e.PracownikNazwisko)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Pracownik_Nazwisko");

                entity.Property(e => e.PracownikNrBudynku).HasColumnName("Pracownik_NrBudynku");

                entity.Property(e => e.PracownikNrMieszkania).HasColumnName("Pracownik_NrMieszkania");

                entity.Property(e => e.PracownikNumerTelefonu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Pracownik_NumerTelefonu");

                entity.Property(e => e.PracownikUlica)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Pracownik_Ulica");
            });

            modelBuilder.Entity<Przypisanie>(entity =>
            {
                entity.HasKey(e => e.PrzypisanieId)
                    .HasName("PK_PRZYPISANIE")
                    .IsClustered(false);

                entity.ToTable("Przypisanie");

                entity.HasIndex(e => e.StatusPrzypisaniaId, "Status_Przypisania_FK");

                entity.Property(e => e.PrzypisanieId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Przypisanie_Id");

                entity.Property(e => e.PrzypisanieDataRozpoczecia)
                    .HasColumnType("datetime")
                    .HasColumnName("Przypisanie_DataRozpoczecia");

                entity.Property(e => e.PrzypisanieDataZakonczenia)
                    .HasColumnType("datetime")
                    .HasColumnName("Przypisanie_DataZakonczenia");

                entity.Property(e => e.StatusPrzypisaniaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("StatusPrzypisania_Id");

                entity.HasOne(d => d.StatusPrzypisania)
                    .WithMany(p => p.Przypisanies)
                    .HasForeignKey(d => d.StatusPrzypisaniaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRZYPISA_STATUS_PR_STATUS_P");

                entity.HasMany(d => d.Pies)
                    .WithMany(p => p.Przypisanies)
                    .UsingEntity<Dictionary<string, object>>(
                        "PsowPrzypisanie",
                        l => l.HasOne<Pies>().WithMany().HasForeignKey("PiesId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PSOW_PRZ_PSOW_PRZY_PIES"),
                        r => r.HasOne<Przypisanie>().WithMany().HasForeignKey("PrzypisanieId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PSOW_PRZ_PSOW_PRZY_PRZYPISA"),
                        j =>
                        {
                            j.HasKey("PrzypisanieId", "PiesId").HasName("PK_PSOW_PRZYPISANIE");

                            j.ToTable("Psow_Przypisanie");

                            j.HasIndex(new[] { "PiesId" }, "Psow_Przypisanie2_FK");

                            j.HasIndex(new[] { "PrzypisanieId" }, "Psow_Przypisanie_FK");

                            j.IndexerProperty<decimal>("PrzypisanieId").HasColumnType("numeric(18, 0)").HasColumnName("Przypisanie_Id");

                            j.IndexerProperty<decimal>("PiesId").HasColumnType("numeric(18, 0)").HasColumnName("Pies_Id");
                        });

                entity.HasMany(d => d.Pracowniks)
                    .WithMany(p => p.Przypisanies)
                    .UsingEntity<Dictionary<string, object>>(
                        "PrzypisaniePracownika",
                        l => l.HasOne<Pracownik>().WithMany().HasForeignKey("PracownikId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PRZYPISA_PRZYPISAN_PRACOWNI"),
                        r => r.HasOne<Przypisanie>().WithMany().HasForeignKey("PrzypisanieId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PRZYPISA_PRZYPISAN_PRZYPISA"),
                        j =>
                        {
                            j.HasKey("PrzypisanieId", "PracownikId").HasName("PK_PRZYPISANIE_PRACOWNIKA");

                            j.ToTable("Przypisanie_Pracownika");

                            j.HasIndex(new[] { "PracownikId" }, "Przypisanie_Pracownika2_FK");

                            j.HasIndex(new[] { "PrzypisanieId" }, "Przypisanie_Pracownika_FK");

                            j.IndexerProperty<decimal>("PrzypisanieId").HasColumnType("numeric(18, 0)").HasColumnName("Przypisanie_Id");

                            j.IndexerProperty<decimal>("PracownikId").HasColumnType("numeric(18, 0)").HasColumnName("Pracownik_Id");
                        });
            });

            modelBuilder.Entity<Pies>(entity =>
            {
                entity.HasKey(e => e.PiesId)
                    .HasName("PK_PIES")
                    .IsClustered(false);

                entity.HasIndex(e => e.CharakterId, "Charakter_Psow_FK");

                entity.HasIndex(e => e.RasaId, "Rasy_Psow_FK");

                entity.HasIndex(e => e.StrefaId, "Strefy_Psow_FK");

                entity.HasIndex(e => e.WiekId, "Wiek_Psow_FK");

                entity.Property(e => e.PiesId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Pies_Id");

                entity.Property(e => e.CharakterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Charakter_Id");

                entity.Property(e => e.PiesCzyDostepny).HasColumnName("Pies_CzyDostepny");

                entity.Property(e => e.PiesCzySuka).HasColumnName("Pies_CzySuka");

                entity.Property(e => e.PiesDataUrodzenia)
                    .HasColumnType("datetime")
                    .HasColumnName("Pies_DataUrodzenia");

                entity.Property(e => e.PiesKolorWzorSiersci)
                    .HasColumnType("text")
                    .HasColumnName("Pies_KolorWzorSiersci");

                entity.Property(e => e.PiesNazwa)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Pies_Nazwa");

                entity.Property(e => e.PiesOpis)
                    .HasColumnType("text")
                    .HasColumnName("Pies_Opis");

                entity.Property(e => e.PiesZdjecie)
                    .HasColumnType("image")
                    .HasColumnName("Pies_Zdjecie");

                entity.Property(e => e.RasaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Rasa_Id");

                entity.Property(e => e.StrefaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Strefa_Id");

                entity.Property(e => e.WiekId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Wiek_Id");

                entity.HasOne(d => d.Charakter)
                    .WithMany(p => p.Pies)
                    .HasForeignKey(d => d.CharakterId)
                    .HasConstraintName("FK_PIES_CHARAKTER_CHARAKTE");

                entity.HasOne(d => d.Rasa)
                    .WithMany(p => p.Pies)
                    .HasForeignKey(d => d.RasaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PIES_RASY_PSOW_RASA");

                entity.HasOne(d => d.Strefa)
                    .WithMany(p => p.Pies)
                    .HasForeignKey(d => d.StrefaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PIES_STREFY_PS_STREFA");

                entity.HasOne(d => d.Wiek)
                    .WithMany(p => p.Pies)
                    .HasForeignKey(d => d.WiekId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PIES_WIEK_PSOW_WIEK");

                entity.HasMany(d => d.DocelowaGrupas)
                    .WithMany(p => p.Pies)
                    .UsingEntity<Dictionary<string, object>>(
                        "DocelowaGrupaPsow",
                        l => l.HasOne<DocelowaGrupa>().WithMany().HasForeignKey("DocelowaGrupaId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_DOCELOWA_DOCELOWAG_DOCELOWA"),
                        r => r.HasOne<Pies>().WithMany().HasForeignKey("PiesId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_DOCELOWA_DOCELOWAG_PIES"),
                        j =>
                        {
                            j.HasKey("PiesId", "DocelowaGrupaId").HasName("PK_DOCELOWAGRUPA_PSOW");

                            j.ToTable("DocelowaGrupa_Psow");

                            j.HasIndex(new[] { "DocelowaGrupaId" }, "DocelowaGrupa_Psow2_FK");

                            j.HasIndex(new[] { "PiesId" }, "DocelowaGrupa_Psow_FK");

                            j.IndexerProperty<decimal>("PiesId").HasColumnType("numeric(18, 0)").HasColumnName("Pies_Id");

                            j.IndexerProperty<decimal>("DocelowaGrupaId").HasColumnType("numeric(18, 0)").HasColumnName("DocelowaGrupa_Id");
                        });
            });

            modelBuilder.Entity<Rasa>(entity =>
            {
                entity.HasKey(e => e.RasaId)
                    .HasName("PK_RASA")
                    .IsClustered(false);

                entity.ToTable("Rasa");

                entity.Property(e => e.RasaId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Rasa_Id");

                entity.Property(e => e.RasaNazwa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Rasa_Nazwa");
            });

            modelBuilder.Entity<Sczepienie>(entity =>
            {
                entity.HasKey(e => e.SzczepienieId)
                    .HasName("PK_SCZEPIENIE")
                    .IsClustered(false);

                entity.ToTable("Sczepienie");

                entity.HasIndex(e => e.PiesId, "Szczepienie_Psow_FK");

                entity.Property(e => e.SzczepienieId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Szczepienie_Id");

                entity.Property(e => e.PiesId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Pies_Id");

                entity.Property(e => e.SzczepienieData)
                    .HasColumnType("datetime")
                    .HasColumnName("Szczepienie_Data");

                entity.Property(e => e.SzczepienieRodzaj)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Szczepienie_Rodzaj");

                entity.Property(e => e.SzczepienieWaznosc)
                    .HasColumnType("datetime")
                    .HasColumnName("Szczepienie_Waznosc");

                entity.HasOne(d => d.Pies)
                    .WithMany(p => p.Sczepienies)
                    .HasForeignKey(d => d.PiesId)
                    .HasConstraintName("FK_SCZEPIEN_SZCZEPIEN_PIES");
            });

            modelBuilder.Entity<StatusAdopcji>(entity =>
            {
                entity.HasKey(e => e.StatusAdopcjiId)
                    .HasName("PK_STATUS_ADOPCJI")
                    .IsClustered(false);

                entity.ToTable("Status_Adopcji");

                entity.Property(e => e.StatusAdopcjiId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StatusAdopcji_Id");

                entity.Property(e => e.StatusAdopcjiNazwa)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("StatusAdopcji_Nazwa");
            });

            modelBuilder.Entity<StatusPrzypisanium>(entity =>
            {
                entity.HasKey(e => e.StatusPrzypisaniaId)
                    .HasName("PK_STATUS_PRZYPISANIA")
                    .IsClustered(false);

                entity.ToTable("Status_Przypisania");

                entity.Property(e => e.StatusPrzypisaniaId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StatusPrzypisania_Id");

                entity.Property(e => e.StatusPrzypisaniaNazwa)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("StatusPrzypisania_Nazwa");
            });

            modelBuilder.Entity<Strefa>(entity =>
            {
                entity.HasKey(e => e.StrefaId)
                    .HasName("PK_STREFA")
                    .IsClustered(false);

                entity.ToTable("Strefa");

                entity.Property(e => e.StrefaId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Strefa_Id");

                entity.Property(e => e.StrefaNazwa)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Strefa_Nazwa");
            });

            modelBuilder.Entity<Wiek>(entity =>
            {
                entity.HasKey(e => e.WiekId)
                    .HasName("PK_WIEK")
                    .IsClustered(false);

                entity.ToTable("Wiek");

                entity.Property(e => e.WiekId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Wiek_Id");

                entity.Property(e => e.WiekNazwa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Wiek_Nazwa");
            });

            modelBuilder.Entity<Zaufanie>(entity =>
            {
                entity.HasKey(e => e.ZaufanieId)
                    .HasName("PK_ZAUFANIE")
                    .IsClustered(false);

                entity.ToTable("Zaufanie");

                entity.Property(e => e.ZaufanieId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Zaufanie_Id");

                entity.Property(e => e.ZaufanieNazwa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Zaufanie_Nazwa");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
