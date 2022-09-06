using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class Korisnik
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Unesite korisnicko ime")]
        public string KorisnickoIme { get; set; }
        [Required(ErrorMessage ="Unesite email")]
        [Key]
        public string Email { get; set; }
        [Required(ErrorMessage = "Unesite lozinku")]
        public string Lozinka { get; set; }
        [Required(ErrorMessage = "Unesite ime i prezime")]
        public string ImePrezime { get; set; }
        [Required(ErrorMessage = "Unesite datum rodjenja")]
        public DateTime DatumRodjenja { get; set; }
        [Required(ErrorMessage = "Unesite adresu")]
        public string Adresa { get; set; }
        public TipKorisnika Tip { get; set; }
        public string Slika { get; set; }
        public StatusVerifikacije Verifikovan { get; set; }
    }
}
