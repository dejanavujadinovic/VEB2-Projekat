using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace WebApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Email = table.Column<string>(type: "varchar(767)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    KorisnickoIme = table.Column<string>(type: "text", nullable: false),
                    Lozinka = table.Column<string>(type: "text", nullable: false),
                    ImePrezime = table.Column<string>(type: "text", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime", nullable: false),
                    Adresa = table.Column<string>(type: "text", nullable: false),
                    Tip = table.Column<string>(type: "text", nullable: false),
                    Slika = table.Column<string>(type: "text", nullable: true),
                    Verifikovan = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "NovaPorudzbina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Adresa = table.Column<string>(type: "text", nullable: true),
                    Komentar = table.Column<string>(type: "text", nullable: true),
                    Cena = table.Column<float>(type: "float", nullable: false),
                    EmailPotrosaca = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NovaPorudzbina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(type: "text", nullable: true),
                    Cena = table.Column<float>(type: "float", nullable: false),
                    Sastojci = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProizvodKolicina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    Narudzbina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProizvodKolicina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrenutnaPorudzbina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NarudzbinaId = table.Column<int>(type: "int", nullable: false),
                    PocetnoVreme = table.Column<DateTime>(type: "datetime", nullable: false),
                    KrajnjeVreme = table.Column<DateTime>(type: "datetime", nullable: false),
                    EmailDostavljaca = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrenutnaPorudzbina", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "NovaPorudzbina");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "ProizvodKolicina");

            migrationBuilder.DropTable(
                name: "TrenutnaPorudzbina");
        }
    }
}
