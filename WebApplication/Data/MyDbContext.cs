using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<NovaPorudzbina> NovaPorudzbina { get; set; }
        public DbSet<ProizvodKolicina> ProizvodKolicina { get; set; }
        public DbSet<TrenutnaPorudzbina> TrenutnaPorudzbina { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Korisnik>()
                .Property(e => e.Tip)
                .HasConversion(
                v => v.ToString(),
                v => (TipKorisnika)Enum.Parse(typeof(TipKorisnika), v));

            modelBuilder
                .Entity<Korisnik>()
                .Property(e => e.Verifikovan)
                .HasConversion(
                v => v.ToString(),
                v => (StatusVerifikacije)Enum.Parse(typeof(StatusVerifikacije), v));

            modelBuilder
                .Entity<NovaPorudzbina>()
                .Property(e => e.Status)
                .HasConversion(
                v => v.ToString(),
                v => (StatusPorudzbine)Enum.Parse(typeof(StatusPorudzbine), v));

            //modelBuilder
            //    .Entity<ProizvodKolicina>(
            //    eb =>
            //    {
            //        eb.HasNoKey();
            //        eb.ToView("View_ProizvodKolicina");
            //        eb.Property(v => v.Proizvod.Id).HasColumnName("Id");
            //    });
        }
    }
}
