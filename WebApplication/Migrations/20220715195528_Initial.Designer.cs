﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication.Data;

namespace WebApplication.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220715195528_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("WebApplication.Data.Korisnik", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("ImePrezime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Slika")
                        .HasColumnType("text");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Verifikovan")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Email");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("WebApplication.Models.NovaPorudzbina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adresa")
                        .HasColumnType("text");

                    b.Property<float>("Cena")
                        .HasColumnType("float");

                    b.Property<string>("EmailPotrosaca")
                        .HasColumnType("text");

                    b.Property<string>("Komentar")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("NovaPorudzbina");
                });

            modelBuilder.Entity("WebApplication.Models.Proizvod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Cena")
                        .HasColumnType("float");

                    b.Property<string>("Ime")
                        .HasColumnType("text");

                    b.Property<string>("Sastojci")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("WebApplication.Models.ProizvodKolicina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("Narudzbina")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProizvodKolicina");
                });

            modelBuilder.Entity("WebApplication.Models.TrenutnaPorudzbina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailDostavljaca")
                        .HasColumnType("text");

                    b.Property<DateTime>("KrajnjeVreme")
                        .HasColumnType("datetime");

                    b.Property<int>("NarudzbinaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PocetnoVreme")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("TrenutnaPorudzbina");
                });
#pragma warning restore 612, 618
        }
    }
}
