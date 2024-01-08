using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchroniskoWebowka.Migrations
{
    public partial class InitMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Charakter",
                columns: table => new
                {
                    Charakter_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Charakter_Nazwa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHARAKTER", x => x.Charakter_Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Docelowa_grupa",
                columns: table => new
                {
                    DocelowaGrupa_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocelowaGrupa_Nazwa = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOCELOWA_GRUPA", x => x.DocelowaGrupa_Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Pracownik",
                columns: table => new
                {
                    Pracownik_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pracownik_Imie = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Pracownik_Nazwisko = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    Pracownik_DataZatrudnienia = table.Column<DateTime>(type: "datetime", nullable: false),
                    Pracownik_DataZwolnienia = table.Column<DateTime>(type: "datetime", nullable: true),
                    Pracownik_Miesjcowosc = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: false),
                    Pracownik_Ulica = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Pracownik_NrBudynku = table.Column<int>(type: "int", nullable: false),
                    Pracownik_NrMieszkania = table.Column<int>(type: "int", nullable: true),
                    Pracownik_NumerTelefonu = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Pracownik_Email = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Pracownik_CzyAdmin = table.Column<bool>(type: "bit", nullable: true),
                    Pracownik_Haslo = table.Column<string>(type: "char(30)", unicode: false, fixedLength: true, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRACOWNIK", x => x.Pracownik_Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Rasa",
                columns: table => new
                {
                    Rasa_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rasa_Nazwa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RASA", x => x.Rasa_Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Status_Adopcji",
                columns: table => new
                {
                    StatusAdopcji_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusAdopcji_Nazwa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATUS_ADOPCJI", x => x.StatusAdopcji_Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Status_Przypisania",
                columns: table => new
                {
                    StatusPrzypisania_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusPrzypisania_Nazwa = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATUS_PRZYPISANIA", x => x.StatusPrzypisania_Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Strefa",
                columns: table => new
                {
                    Strefa_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strefa_Nazwa = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STREFA", x => x.Strefa_Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Wiek",
                columns: table => new
                {
                    Wiek_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wiek_Nazwa = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WIEK", x => x.Wiek_Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Zaufanie",
                columns: table => new
                {
                    Zaufanie_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zaufanie_Nazwa = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZAUFANIE", x => x.Zaufanie_Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Przypisanie",
                columns: table => new
                {
                    Przypisanie_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusPrzypisania_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Przypisanie_DataRozpoczecia = table.Column<DateTime>(type: "datetime", nullable: false),
                    Przypisanie_DataZakonczenia = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRZYPISANIE", x => x.Przypisanie_Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PRZYPISA_STATUS_PR_STATUS_P",
                        column: x => x.StatusPrzypisania_Id,
                        principalTable: "Status_Przypisania",
                        principalColumn: "StatusPrzypisania_Id");
                });

            migrationBuilder.CreateTable(
                name: "Pies",
                columns: table => new
                {
                    Pies_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strefa_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Charakter_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Rasa_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Wiek_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Pies_Nazwa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Pies_CzySuka = table.Column<bool>(type: "bit", nullable: true),
                    Pies_DataUrodzenia = table.Column<DateTime>(type: "datetime", nullable: true),
                    Pies_Zdjecie = table.Column<byte[]>(type: "image", nullable: true),
                    Pies_CzyDostepny = table.Column<bool>(type: "bit", nullable: false),
                    Pies_KolorWzorSiersci = table.Column<string>(type: "text", nullable: true),
                    Pies_Opis = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIES", x => x.Pies_Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PIES_CHARAKTER_CHARAKTE",
                        column: x => x.Charakter_Id,
                        principalTable: "Charakter",
                        principalColumn: "Charakter_Id");
                    table.ForeignKey(
                        name: "FK_PIES_RASY_PSOW_RASA",
                        column: x => x.Rasa_Id,
                        principalTable: "Rasa",
                        principalColumn: "Rasa_Id");
                    table.ForeignKey(
                        name: "FK_PIES_STREFY_PS_STREFA",
                        column: x => x.Strefa_Id,
                        principalTable: "Strefa",
                        principalColumn: "Strefa_Id");
                    table.ForeignKey(
                        name: "FK_PIES_WIEK_PSOW_WIEK",
                        column: x => x.Wiek_Id,
                        principalTable: "Wiek",
                        principalColumn: "Wiek_Id");
                });

            migrationBuilder.CreateTable(
                name: "Adoptujacy",
                columns: table => new
                {
                    Adoptujacy_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zaufanie_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Adoptujacy_Imie = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    Adoptujacy_Nazwisko = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Adoptujacy_CzyKobieta = table.Column<bool>(type: "bit", nullable: true),
                    Adoptujacy_Miejscowosc = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: false),
                    Adoptujacy_Ulica = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Adoptujacy_NrBudynku = table.Column<int>(type: "int", nullable: false),
                    Adoptujacy_NrMieszkania = table.Column<int>(type: "int", nullable: true),
                    Adoptujacy_Telefon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADOPTUJACY", x => x.Adoptujacy_Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_ADOPTUJA_ZAUFANIE__ZAUFANIE",
                        column: x => x.Zaufanie_Id,
                        principalTable: "Zaufanie",
                        principalColumn: "Zaufanie_Id");
                });

            migrationBuilder.CreateTable(
                name: "Przypisanie_Pracownika",
                columns: table => new
                {
                    Przypisanie_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Pracownik_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRZYPISANIE_PRACOWNIKA", x => new { x.Przypisanie_Id, x.Pracownik_Id });
                    table.ForeignKey(
                        name: "FK_PRZYPISA_PRZYPISAN_PRACOWNI",
                        column: x => x.Pracownik_Id,
                        principalTable: "Pracownik",
                        principalColumn: "Pracownik_Id");
                    table.ForeignKey(
                        name: "FK_PRZYPISA_PRZYPISAN_PRZYPISA",
                        column: x => x.Przypisanie_Id,
                        principalTable: "Przypisanie",
                        principalColumn: "Przypisanie_Id");
                });

            migrationBuilder.CreateTable(
                name: "DocelowaGrupa_Psow",
                columns: table => new
                {
                    Pies_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    DocelowaGrupa_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOCELOWAGRUPA_PSOW", x => new { x.Pies_Id, x.DocelowaGrupa_Id });
                    table.ForeignKey(
                        name: "FK_DOCELOWA_DOCELOWAG_DOCELOWA",
                        column: x => x.DocelowaGrupa_Id,
                        principalTable: "Docelowa_grupa",
                        principalColumn: "DocelowaGrupa_Id");
                    table.ForeignKey(
                        name: "FK_DOCELOWA_DOCELOWAG_PIES",
                        column: x => x.Pies_Id,
                        principalTable: "Pies",
                        principalColumn: "Pies_Id");
                });

            migrationBuilder.CreateTable(
                name: "Historia_Leczenia",
                columns: table => new
                {
                    HistoriaLeczenia_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pies_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    HistoriaLeczenia_Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    HistoriaLeczenia_Naglowek = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    HistoriaLeczenia_Opis = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HISTORIA_LECZENIA", x => x.HistoriaLeczenia_Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_HISTORIA_HISTORIAL_PIES",
                        column: x => x.Pies_Id,
                        principalTable: "Pies",
                        principalColumn: "Pies_Id");
                });

            migrationBuilder.CreateTable(
                name: "Leki",
                columns: table => new
                {
                    Lek_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pies_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Lek_Nazwa = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Lek_Dawka = table.Column<short>(type: "smallint", nullable: false),
                    Lek_Czestotliwosc = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Lek_DataRozpoczecia = table.Column<DateTime>(type: "datetime", nullable: false),
                    Lek_DataZakonczenia = table.Column<DateTime>(type: "datetime", nullable: true),
                    Lek_Opis = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEKI", x => x.Lek_Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_LEKI_LEKI_PSOW_PIES",
                        column: x => x.Pies_Id,
                        principalTable: "Pies",
                        principalColumn: "Pies_Id");
                });

            migrationBuilder.CreateTable(
                name: "Psow_Przypisanie",
                columns: table => new
                {
                    Przypisanie_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Pies_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSOW_PRZYPISANIE", x => new { x.Przypisanie_Id, x.Pies_Id });
                    table.ForeignKey(
                        name: "FK_PSOW_PRZ_PSOW_PRZY_PIES",
                        column: x => x.Pies_Id,
                        principalTable: "Pies",
                        principalColumn: "Pies_Id");
                    table.ForeignKey(
                        name: "FK_PSOW_PRZ_PSOW_PRZY_PRZYPISA",
                        column: x => x.Przypisanie_Id,
                        principalTable: "Przypisanie",
                        principalColumn: "Przypisanie_Id");
                });

            migrationBuilder.CreateTable(
                name: "Sczepienie",
                columns: table => new
                {
                    Szczepienie_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pies_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Szczepienie_Rodzaj = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    Szczepienie_Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    Szczepienie_Waznosc = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCZEPIENIE", x => x.Szczepienie_Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_SCZEPIEN_SZCZEPIEN_PIES",
                        column: x => x.Pies_Id,
                        principalTable: "Pies",
                        principalColumn: "Pies_Id");
                });

            migrationBuilder.CreateTable(
                name: "Historia_Adopcji",
                columns: table => new
                {
                    HistoriaAdopicji_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusAdopcji_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Pies_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Adoptujacy_Id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    HistoriaAdopicji_Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    HistoriaAdopicji_Oplata = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HISTORIA_ADOPCJI", x => x.HistoriaAdopicji_Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_HISTORIA_ADOPTUJAC_ADOPTUJA",
                        column: x => x.Adoptujacy_Id,
                        principalTable: "Adoptujacy",
                        principalColumn: "Adoptujacy_Id");
                    table.ForeignKey(
                        name: "FK_HISTORIA_HISTORIEA_PIES",
                        column: x => x.Pies_Id,
                        principalTable: "Pies",
                        principalColumn: "Pies_Id");
                    table.ForeignKey(
                        name: "FK_HISTORIA_STATUS_HI_STATUS_A",
                        column: x => x.StatusAdopcji_Id,
                        principalTable: "Status_Adopcji",
                        principalColumn: "StatusAdopcji_Id");
                });

            migrationBuilder.CreateIndex(
                name: "Zaufanie_Do_Adoptujacego_FK",
                table: "Adoptujacy",
                column: "Zaufanie_Id");

            migrationBuilder.CreateIndex(
                name: "DocelowaGrupa_Psow_FK",
                table: "DocelowaGrupa_Psow",
                column: "Pies_Id");

            migrationBuilder.CreateIndex(
                name: "DocelowaGrupa_Psow2_FK",
                table: "DocelowaGrupa_Psow",
                column: "DocelowaGrupa_Id");

            migrationBuilder.CreateIndex(
                name: "Adoptujacy_HistoriaAdopcji_FK",
                table: "Historia_Adopcji",
                column: "Adoptujacy_Id");

            migrationBuilder.CreateIndex(
                name: "HistorieAdopcji_Psow_FK",
                table: "Historia_Adopcji",
                column: "Pies_Id");

            migrationBuilder.CreateIndex(
                name: "Status_Historii_Adopcji_FK",
                table: "Historia_Adopcji",
                column: "StatusAdopcji_Id");

            migrationBuilder.CreateIndex(
                name: "HistoriaLeczenia_Psow_FK",
                table: "Historia_Leczenia",
                column: "Pies_Id");

            migrationBuilder.CreateIndex(
                name: "Leki_Psow_FK",
                table: "Leki",
                column: "Pies_Id");

            migrationBuilder.CreateIndex(
                name: "Charakter_Psow_FK",
                table: "Pies",
                column: "Charakter_Id");

            migrationBuilder.CreateIndex(
                name: "Rasy_Psow_FK",
                table: "Pies",
                column: "Rasa_Id");

            migrationBuilder.CreateIndex(
                name: "Strefy_Psow_FK",
                table: "Pies",
                column: "Strefa_Id");

            migrationBuilder.CreateIndex(
                name: "Wiek_Psow_FK",
                table: "Pies",
                column: "Wiek_Id");

            migrationBuilder.CreateIndex(
                name: "Status_Przypisania_FK",
                table: "Przypisanie",
                column: "StatusPrzypisania_Id");

            migrationBuilder.CreateIndex(
                name: "Przypisanie_Pracownika_FK",
                table: "Przypisanie_Pracownika",
                column: "Przypisanie_Id");

            migrationBuilder.CreateIndex(
                name: "Przypisanie_Pracownika2_FK",
                table: "Przypisanie_Pracownika",
                column: "Pracownik_Id");

            migrationBuilder.CreateIndex(
                name: "Psow_Przypisanie_FK",
                table: "Psow_Przypisanie",
                column: "Przypisanie_Id");

            migrationBuilder.CreateIndex(
                name: "Psow_Przypisanie2_FK",
                table: "Psow_Przypisanie",
                column: "Pies_Id");

            migrationBuilder.CreateIndex(
                name: "Szczepienie_Psow_FK",
                table: "Sczepienie",
                column: "Pies_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocelowaGrupa_Psow");

            migrationBuilder.DropTable(
                name: "Historia_Adopcji");

            migrationBuilder.DropTable(
                name: "Historia_Leczenia");

            migrationBuilder.DropTable(
                name: "Leki");

            migrationBuilder.DropTable(
                name: "Przypisanie_Pracownika");

            migrationBuilder.DropTable(
                name: "Psow_Przypisanie");

            migrationBuilder.DropTable(
                name: "Sczepienie");

            migrationBuilder.DropTable(
                name: "Docelowa_grupa");

            migrationBuilder.DropTable(
                name: "Adoptujacy");

            migrationBuilder.DropTable(
                name: "Status_Adopcji");

            migrationBuilder.DropTable(
                name: "Pracownik");

            migrationBuilder.DropTable(
                name: "Przypisanie");

            migrationBuilder.DropTable(
                name: "Pies");

            migrationBuilder.DropTable(
                name: "Zaufanie");

            migrationBuilder.DropTable(
                name: "Status_Przypisania");

            migrationBuilder.DropTable(
                name: "Charakter");

            migrationBuilder.DropTable(
                name: "Rasa");

            migrationBuilder.DropTable(
                name: "Strefa");

            migrationBuilder.DropTable(
                name: "Wiek");
        }
    }
}
