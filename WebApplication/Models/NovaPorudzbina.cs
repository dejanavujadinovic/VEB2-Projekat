using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class NovaPorudzbina
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public List<ProizvodKolicina> Proizvod { get; set;  }
        public string Adresa { get; set; }
        public string Komentar { get; set; }
        public float Cena { get; set; }
        public string EmailPotrosaca { get; set; }
        public StatusPorudzbine Status { get; set; }
        //public NovaPorudzbina(int id, List<Proizvod> proizvodi, int kolicina, string adresa, string komentar, float cena)
        //{
        //    Id = id;
        //    Proizvodi = proizvodi;
        //    Kolicina = kolicina;
        //    Adresa = adresa;
        //    Komentar = komentar;
        //    Cena = cena;
        //}
    }
}
