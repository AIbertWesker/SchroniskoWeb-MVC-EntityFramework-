﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchroniskoWebowka.Models;

#nullable disable

namespace SchroniskoWebowka.Migrations
{
    [DbContext(typeof(SchroniskoContext))]
    partial class SchroniskoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DocelowaGrupaPsow", b =>
                {
                    b.Property<decimal>("PiesId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Pies_Id");

                    b.Property<decimal>("DocelowaGrupaId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("DocelowaGrupa_Id");

                    b.HasKey("PiesId", "DocelowaGrupaId")
                        .HasName("PK_DOCELOWAGRUPA_PSOW");

                    b.HasIndex(new[] { "DocelowaGrupaId" }, "DocelowaGrupa_Psow2_FK");

                    b.HasIndex(new[] { "PiesId" }, "DocelowaGrupa_Psow_FK");

                    b.ToTable("DocelowaGrupa_Psow", (string)null);
                });

            modelBuilder.Entity("PrzypisaniePracownika", b =>
                {
                    b.Property<decimal>("PrzypisanieId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Przypisanie_Id");

                    b.Property<decimal>("PracownikId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Pracownik_Id");

                    b.HasKey("PrzypisanieId", "PracownikId")
                        .HasName("PK_PRZYPISANIE_PRACOWNIKA");

                    b.HasIndex(new[] { "PracownikId" }, "Przypisanie_Pracownika2_FK");

                    b.HasIndex(new[] { "PrzypisanieId" }, "Przypisanie_Pracownika_FK");

                    b.ToTable("Przypisanie_Pracownika", (string)null);
                });

            modelBuilder.Entity("PsowPrzypisanie", b =>
                {
                    b.Property<decimal>("PrzypisanieId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Przypisanie_Id");

                    b.Property<decimal>("PiesId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Pies_Id");

                    b.HasKey("PrzypisanieId", "PiesId")
                        .HasName("PK_PSOW_PRZYPISANIE");

                    b.HasIndex(new[] { "PiesId" }, "Psow_Przypisanie2_FK");

                    b.HasIndex(new[] { "PrzypisanieId" }, "Psow_Przypisanie_FK");

                    b.ToTable("Psow_Przypisanie", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Adoptujacy", b =>
                {
                    b.Property<decimal>("AdoptujacyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Adoptujacy_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("AdoptujacyId"), 1L, 1);

                    b.Property<bool?>("AdoptujacyCzyKobieta")
                        .HasColumnType("bit")
                        .HasColumnName("Adoptujacy_CzyKobieta");

                    b.Property<string>("AdoptujacyImie")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Adoptujacy_Imie");

                    b.Property<string>("AdoptujacyMiejscowosc")
                        .IsRequired()
                        .HasMaxLength(70)
                        .IsUnicode(false)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("Adoptujacy_Miejscowosc");

                    b.Property<string>("AdoptujacyNazwisko")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("Adoptujacy_Nazwisko");

                    b.Property<int>("AdoptujacyNrBudynku")
                        .HasColumnType("int")
                        .HasColumnName("Adoptujacy_NrBudynku");

                    b.Property<int?>("AdoptujacyNrMieszkania")
                        .HasColumnType("int")
                        .HasColumnName("Adoptujacy_NrMieszkania");

                    b.Property<string>("AdoptujacyTelefon")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("Adoptujacy_Telefon");

                    b.Property<string>("AdoptujacyUlica")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Adoptujacy_Ulica");

                    b.Property<decimal?>("ZaufanieId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Zaufanie_Id");

                    b.HasKey("AdoptujacyId")
                        .HasName("PK_ADOPTUJACY");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("AdoptujacyId"), false);

                    b.HasIndex(new[] { "ZaufanieId" }, "Zaufanie_Do_Adoptujacego_FK");

                    b.ToTable("Adoptujacy", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Charakter", b =>
                {
                    b.Property<decimal>("CharakterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Charakter_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("CharakterId"), 1L, 1);

                    b.Property<string>("CharakterNazwa")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Charakter_Nazwa");

                    b.HasKey("CharakterId")
                        .HasName("PK_CHARAKTER");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("CharakterId"), false);

                    b.ToTable("Charakter", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.DocelowaGrupa", b =>
                {
                    b.Property<decimal>("DocelowaGrupaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("DocelowaGrupa_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("DocelowaGrupaId"), 1L, 1);

                    b.Property<string>("DocelowaGrupaNazwa")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("DocelowaGrupa_Nazwa");

                    b.HasKey("DocelowaGrupaId")
                        .HasName("PK_DOCELOWA_GRUPA");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("DocelowaGrupaId"), false);

                    b.ToTable("Docelowa_grupa", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.HistoriaAdopcji", b =>
                {
                    b.Property<decimal>("HistoriaAdopicjiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("HistoriaAdopicji_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("HistoriaAdopicjiId"), 1L, 1);

                    b.Property<decimal>("AdoptujacyId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Adoptujacy_Id");

                    b.Property<DateTime>("HistoriaAdopicjiData")
                        .HasColumnType("datetime")
                        .HasColumnName("HistoriaAdopicji_Data");

                    b.Property<decimal?>("HistoriaAdopicjiOplata")
                        .HasColumnType("money")
                        .HasColumnName("HistoriaAdopicji_Oplata");

                    b.Property<decimal?>("PiesId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Pies_Id");

                    b.Property<decimal>("StatusAdopcjiId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("StatusAdopcji_Id");

                    b.HasKey("HistoriaAdopicjiId")
                        .HasName("PK_HISTORIA_ADOPCJI");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("HistoriaAdopicjiId"), false);

                    b.HasIndex(new[] { "AdoptujacyId" }, "Adoptujacy_HistoriaAdopcji_FK");

                    b.HasIndex(new[] { "PiesId" }, "HistorieAdopcji_Psow_FK");

                    b.HasIndex(new[] { "StatusAdopcjiId" }, "Status_Historii_Adopcji_FK");

                    b.ToTable("Historia_Adopcji", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.HistoriaLeczenium", b =>
                {
                    b.Property<decimal>("HistoriaLeczeniaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("HistoriaLeczenia_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("HistoriaLeczeniaId"), 1L, 1);

                    b.Property<DateTime>("HistoriaLeczeniaData")
                        .HasColumnType("datetime")
                        .HasColumnName("HistoriaLeczenia_Data");

                    b.Property<string>("HistoriaLeczeniaNaglowek")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("HistoriaLeczenia_Naglowek");

                    b.Property<string>("HistoriaLeczeniaOpis")
                        .HasColumnType("text")
                        .HasColumnName("HistoriaLeczenia_Opis");

                    b.Property<decimal?>("PiesId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Pies_Id");

                    b.HasKey("HistoriaLeczeniaId")
                        .HasName("PK_HISTORIA_LECZENIA");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("HistoriaLeczeniaId"), false);

                    b.HasIndex(new[] { "PiesId" }, "HistoriaLeczenia_Psow_FK");

                    b.ToTable("Historia_Leczenia", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Leki", b =>
                {
                    b.Property<decimal>("LekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Lek_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("LekId"), 1L, 1);

                    b.Property<string>("LekCzestotliwosc")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("Lek_Czestotliwosc");

                    b.Property<DateTime>("LekDataRozpoczecia")
                        .HasColumnType("datetime")
                        .HasColumnName("Lek_DataRozpoczecia");

                    b.Property<DateTime?>("LekDataZakonczenia")
                        .HasColumnType("datetime")
                        .HasColumnName("Lek_DataZakonczenia");

                    b.Property<short>("LekDawka")
                        .HasColumnType("smallint")
                        .HasColumnName("Lek_Dawka");

                    b.Property<string>("LekNazwa")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("Lek_Nazwa");

                    b.Property<string>("LekOpis")
                        .HasColumnType("text")
                        .HasColumnName("Lek_Opis");

                    b.Property<decimal?>("PiesId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Pies_Id");

                    b.HasKey("LekId")
                        .HasName("PK_LEKI");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("LekId"), false);

                    b.HasIndex(new[] { "PiesId" }, "Leki_Psow_FK");

                    b.ToTable("Leki", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Pies", b =>
                {
                    b.Property<decimal>("PiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Pies_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("PiesId"), 1L, 1);

                    b.Property<decimal?>("CharakterId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Charakter_Id");

                    b.Property<bool>("PiesCzyDostepny")
                        .HasColumnType("bit")
                        .HasColumnName("Pies_CzyDostepny");

                    b.Property<bool?>("PiesCzySuka")
                        .HasColumnType("bit")
                        .HasColumnName("Pies_CzySuka");

                    b.Property<DateTime?>("PiesDataUrodzenia")
                        .HasColumnType("datetime")
                        .HasColumnName("Pies_DataUrodzenia");

                    b.Property<string>("PiesKolorWzorSiersci")
                        .HasColumnType("text")
                        .HasColumnName("Pies_KolorWzorSiersci");

                    b.Property<string>("PiesNazwa")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Pies_Nazwa");

                    b.Property<string>("PiesOpis")
                        .HasColumnType("text")
                        .HasColumnName("Pies_Opis");

                    b.Property<byte[]>("PiesZdjecie")
                        .HasColumnType("image")
                        .HasColumnName("Pies_Zdjecie");

                    b.Property<decimal>("RasaId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Rasa_Id");

                    b.Property<decimal>("StrefaId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Strefa_Id");

                    b.Property<decimal>("WiekId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Wiek_Id");

                    b.HasKey("PiesId")
                        .HasName("PK_PIES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("PiesId"), false);

                    b.HasIndex(new[] { "CharakterId" }, "Charakter_Psow_FK");

                    b.HasIndex(new[] { "RasaId" }, "Rasy_Psow_FK");

                    b.HasIndex(new[] { "StrefaId" }, "Strefy_Psow_FK");

                    b.HasIndex(new[] { "WiekId" }, "Wiek_Psow_FK");

                    b.ToTable("Pies");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Pracownik", b =>
                {
                    b.Property<decimal>("PracownikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Pracownik_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("PracownikId"), 1L, 1);

                    b.Property<bool?>("PracownikCzyAdmin")
                        .HasColumnType("bit")
                        .HasColumnName("Pracownik_CzyAdmin");

                    b.Property<DateTime>("PracownikDataZatrudnienia")
                        .HasColumnType("datetime")
                        .HasColumnName("Pracownik_DataZatrudnienia");

                    b.Property<DateTime?>("PracownikDataZwolnienia")
                        .HasColumnType("datetime")
                        .HasColumnName("Pracownik_DataZwolnienia");

                    b.Property<string>("PracownikEmail")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("Pracownik_Email");

                    b.Property<string>("PracownikHaslo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("char(30)")
                        .HasColumnName("Pracownik_Haslo")
                        .IsFixedLength();

                    b.Property<string>("PracownikImie")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Pracownik_Imie");

                    b.Property<string>("PracownikMiesjcowosc")
                        .IsRequired()
                        .HasMaxLength(70)
                        .IsUnicode(false)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("Pracownik_Miesjcowosc");

                    b.Property<string>("PracownikNazwisko")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Pracownik_Nazwisko");

                    b.Property<int>("PracownikNrBudynku")
                        .HasColumnType("int")
                        .HasColumnName("Pracownik_NrBudynku");

                    b.Property<int?>("PracownikNrMieszkania")
                        .HasColumnType("int")
                        .HasColumnName("Pracownik_NrMieszkania");

                    b.Property<string>("PracownikNumerTelefonu")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("Pracownik_NumerTelefonu");

                    b.Property<string>("PracownikUlica")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("Pracownik_Ulica");

                    b.HasKey("PracownikId")
                        .HasName("PK_PRACOWNIK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("PracownikId"), false);

                    b.ToTable("Pracownik", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Przypisanie", b =>
                {
                    b.Property<decimal>("PrzypisanieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Przypisanie_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("PrzypisanieId"), 1L, 1);

                    b.Property<DateTime>("PrzypisanieDataRozpoczecia")
                        .HasColumnType("datetime")
                        .HasColumnName("Przypisanie_DataRozpoczecia");

                    b.Property<DateTime?>("PrzypisanieDataZakonczenia")
                        .HasColumnType("datetime")
                        .HasColumnName("Przypisanie_DataZakonczenia");

                    b.Property<decimal>("StatusPrzypisaniaId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("StatusPrzypisania_Id");

                    b.HasKey("PrzypisanieId")
                        .HasName("PK_PRZYPISANIE");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("PrzypisanieId"), false);

                    b.HasIndex(new[] { "StatusPrzypisaniaId" }, "Status_Przypisania_FK");

                    b.ToTable("Przypisanie", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Rasa", b =>
                {
                    b.Property<decimal>("RasaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Rasa_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("RasaId"), 1L, 1);

                    b.Property<string>("RasaNazwa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Rasa_Nazwa");

                    b.HasKey("RasaId")
                        .HasName("PK_RASA");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("RasaId"), false);

                    b.ToTable("Rasa", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Sczepienie", b =>
                {
                    b.Property<decimal>("SzczepienieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Szczepienie_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("SzczepienieId"), 1L, 1);

                    b.Property<decimal?>("PiesId")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Pies_Id");

                    b.Property<DateTime>("SzczepienieData")
                        .HasColumnType("datetime")
                        .HasColumnName("Szczepienie_Data");

                    b.Property<string>("SzczepienieRodzaj")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Szczepienie_Rodzaj");

                    b.Property<DateTime?>("SzczepienieWaznosc")
                        .HasColumnType("datetime")
                        .HasColumnName("Szczepienie_Waznosc");

                    b.HasKey("SzczepienieId")
                        .HasName("PK_SCZEPIENIE");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("SzczepienieId"), false);

                    b.HasIndex(new[] { "PiesId" }, "Szczepienie_Psow_FK");

                    b.ToTable("Sczepienie", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.StatusAdopcji", b =>
                {
                    b.Property<decimal>("StatusAdopcjiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("StatusAdopcji_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("StatusAdopcjiId"), 1L, 1);

                    b.Property<string>("StatusAdopcjiNazwa")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("StatusAdopcji_Nazwa");

                    b.HasKey("StatusAdopcjiId")
                        .HasName("PK_STATUS_ADOPCJI");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("StatusAdopcjiId"), false);

                    b.ToTable("Status_Adopcji", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.StatusPrzypisanium", b =>
                {
                    b.Property<decimal>("StatusPrzypisaniaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("StatusPrzypisania_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("StatusPrzypisaniaId"), 1L, 1);

                    b.Property<string>("StatusPrzypisaniaNazwa")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("StatusPrzypisania_Nazwa");

                    b.HasKey("StatusPrzypisaniaId")
                        .HasName("PK_STATUS_PRZYPISANIA");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("StatusPrzypisaniaId"), false);

                    b.ToTable("Status_Przypisania", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Strefa", b =>
                {
                    b.Property<decimal>("StrefaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Strefa_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("StrefaId"), 1L, 1);

                    b.Property<string>("StrefaNazwa")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Strefa_Nazwa");

                    b.HasKey("StrefaId")
                        .HasName("PK_STREFA");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("StrefaId"), false);

                    b.ToTable("Strefa", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Wiek", b =>
                {
                    b.Property<decimal>("WiekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Wiek_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("WiekId"), 1L, 1);

                    b.Property<string>("WiekNazwa")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Wiek_Nazwa");

                    b.HasKey("WiekId")
                        .HasName("PK_WIEK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("WiekId"), false);

                    b.ToTable("Wiek", (string)null);
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Zaufanie", b =>
                {
                    b.Property<decimal>("ZaufanieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("Zaufanie_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("ZaufanieId"), 1L, 1);

                    b.Property<string>("ZaufanieNazwa")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Zaufanie_Nazwa");

                    b.HasKey("ZaufanieId")
                        .HasName("PK_ZAUFANIE");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("ZaufanieId"), false);

                    b.ToTable("Zaufanie", (string)null);
                });

            modelBuilder.Entity("DocelowaGrupaPsow", b =>
                {
                    b.HasOne("SchroniskoWebowka.Models.DocelowaGrupa", null)
                        .WithMany()
                        .HasForeignKey("DocelowaGrupaId")
                        .IsRequired()
                        .HasConstraintName("FK_DOCELOWA_DOCELOWAG_DOCELOWA");

                    b.HasOne("SchroniskoWebowka.Models.Pies", null)
                        .WithMany()
                        .HasForeignKey("PiesId")
                        .IsRequired()
                        .HasConstraintName("FK_DOCELOWA_DOCELOWAG_PIES");
                });

            modelBuilder.Entity("PrzypisaniePracownika", b =>
                {
                    b.HasOne("SchroniskoWebowka.Models.Pracownik", null)
                        .WithMany()
                        .HasForeignKey("PracownikId")
                        .IsRequired()
                        .HasConstraintName("FK_PRZYPISA_PRZYPISAN_PRACOWNI");

                    b.HasOne("SchroniskoWebowka.Models.Przypisanie", null)
                        .WithMany()
                        .HasForeignKey("PrzypisanieId")
                        .IsRequired()
                        .HasConstraintName("FK_PRZYPISA_PRZYPISAN_PRZYPISA");
                });

            modelBuilder.Entity("PsowPrzypisanie", b =>
                {
                    b.HasOne("SchroniskoWebowka.Models.Pies", null)
                        .WithMany()
                        .HasForeignKey("PiesId")
                        .IsRequired()
                        .HasConstraintName("FK_PSOW_PRZ_PSOW_PRZY_PIES");

                    b.HasOne("SchroniskoWebowka.Models.Przypisanie", null)
                        .WithMany()
                        .HasForeignKey("PrzypisanieId")
                        .IsRequired()
                        .HasConstraintName("FK_PSOW_PRZ_PSOW_PRZY_PRZYPISA");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Adoptujacy", b =>
                {
                    b.HasOne("SchroniskoWebowka.Models.Zaufanie", "Zaufanie")
                        .WithMany("Adoptujacies")
                        .HasForeignKey("ZaufanieId")
                        .HasConstraintName("FK_ADOPTUJA_ZAUFANIE__ZAUFANIE");

                    b.Navigation("Zaufanie");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.HistoriaAdopcji", b =>
                {
                    b.HasOne("SchroniskoWebowka.Models.Adoptujacy", "Adoptujacy")
                        .WithMany("HistoriaAdopcjis")
                        .HasForeignKey("AdoptujacyId")
                        .IsRequired()
                        .HasConstraintName("FK_HISTORIA_ADOPTUJAC_ADOPTUJA");

                    b.HasOne("SchroniskoWebowka.Models.Pies", "Pies")
                        .WithMany("HistoriaAdopcjis")
                        .HasForeignKey("PiesId")
                        .HasConstraintName("FK_HISTORIA_HISTORIEA_PIES");

                    b.HasOne("SchroniskoWebowka.Models.StatusAdopcji", "StatusAdopcji")
                        .WithMany("HistoriaAdopcjis")
                        .HasForeignKey("StatusAdopcjiId")
                        .IsRequired()
                        .HasConstraintName("FK_HISTORIA_STATUS_HI_STATUS_A");

                    b.Navigation("Adoptujacy");

                    b.Navigation("Pies");

                    b.Navigation("StatusAdopcji");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.HistoriaLeczenium", b =>
                {
                    b.HasOne("SchroniskoWebowka.Models.Pies", "Pies")
                        .WithMany("HistoriaLeczenia")
                        .HasForeignKey("PiesId")
                        .HasConstraintName("FK_HISTORIA_HISTORIAL_PIES");

                    b.Navigation("Pies");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Leki", b =>
                {
                    b.HasOne("SchroniskoWebowka.Models.Pies", "Pies")
                        .WithMany("Lekis")
                        .HasForeignKey("PiesId")
                        .HasConstraintName("FK_LEKI_LEKI_PSOW_PIES");

                    b.Navigation("Pies");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Pies", b =>
                {
                    b.HasOne("SchroniskoWebowka.Models.Charakter", "Charakter")
                        .WithMany("Pies")
                        .HasForeignKey("CharakterId")
                        .HasConstraintName("FK_PIES_CHARAKTER_CHARAKTE");

                    b.HasOne("SchroniskoWebowka.Models.Rasa", "Rasa")
                        .WithMany("Pies")
                        .HasForeignKey("RasaId")
                        .IsRequired()
                        .HasConstraintName("FK_PIES_RASY_PSOW_RASA");

                    b.HasOne("SchroniskoWebowka.Models.Strefa", "Strefa")
                        .WithMany("Pies")
                        .HasForeignKey("StrefaId")
                        .IsRequired()
                        .HasConstraintName("FK_PIES_STREFY_PS_STREFA");

                    b.HasOne("SchroniskoWebowka.Models.Wiek", "Wiek")
                        .WithMany("Pies")
                        .HasForeignKey("WiekId")
                        .IsRequired()
                        .HasConstraintName("FK_PIES_WIEK_PSOW_WIEK");

                    b.Navigation("Charakter");

                    b.Navigation("Rasa");

                    b.Navigation("Strefa");

                    b.Navigation("Wiek");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Przypisanie", b =>
                {
                    b.HasOne("SchroniskoWebowka.Models.StatusPrzypisanium", "StatusPrzypisania")
                        .WithMany("Przypisanies")
                        .HasForeignKey("StatusPrzypisaniaId")
                        .IsRequired()
                        .HasConstraintName("FK_PRZYPISA_STATUS_PR_STATUS_P");

                    b.Navigation("StatusPrzypisania");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Sczepienie", b =>
                {
                    b.HasOne("SchroniskoWebowka.Models.Pies", "Pies")
                        .WithMany("Sczepienies")
                        .HasForeignKey("PiesId")
                        .HasConstraintName("FK_SCZEPIEN_SZCZEPIEN_PIES");

                    b.Navigation("Pies");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Adoptujacy", b =>
                {
                    b.Navigation("HistoriaAdopcjis");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Charakter", b =>
                {
                    b.Navigation("Pies");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Pies", b =>
                {
                    b.Navigation("HistoriaAdopcjis");

                    b.Navigation("HistoriaLeczenia");

                    b.Navigation("Lekis");

                    b.Navigation("Sczepienies");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Rasa", b =>
                {
                    b.Navigation("Pies");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.StatusAdopcji", b =>
                {
                    b.Navigation("HistoriaAdopcjis");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.StatusPrzypisanium", b =>
                {
                    b.Navigation("Przypisanies");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Strefa", b =>
                {
                    b.Navigation("Pies");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Wiek", b =>
                {
                    b.Navigation("Pies");
                });

            modelBuilder.Entity("SchroniskoWebowka.Models.Zaufanie", b =>
                {
                    b.Navigation("Adoptujacies");
                });
#pragma warning restore 612, 618
        }
    }
}
