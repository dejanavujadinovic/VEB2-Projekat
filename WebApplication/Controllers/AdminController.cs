using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AdminController : Controller
    {
        //private readonly ILogger<AdminController> _logger;
        private readonly MyDbContext _context;
        private static List<Proizvod> proizvodi = new List<Proizvod>();
        private static List<Korisnik> korisnici = new List<Korisnik>();
        private static List<ProizvodKolicina> proizvodKolicina = new List<ProizvodKolicina>();
        private static List<NovaPorudzbina> novaPorudzbina = new List<NovaPorudzbina>();
        private static List<TrenutnaPorudzbina> trenutnaPorudzbina = new List<TrenutnaPorudzbina>();

        public AdminController( MyDbContext context)
        {
            _context = context;
            //proizvodi = _context.Proizvod.ToList();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Profil()
        {
            Korisnik korisnik = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            return View(korisnik);
        }
        public IActionResult UredjenProfil(Korisnik korisnik)
        {
            Korisnik trenutni = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            trenutni.ImePrezime = korisnik.ImePrezime;
            trenutni.KorisnickoIme = korisnik.KorisnickoIme;
            trenutni.Lozinka = korisnik.Lozinka;
            trenutni.DatumRodjenja = korisnik.DatumRodjenja;
            trenutni.Adresa = korisnik.Adresa;
            if(korisnik.Slika==null || korisnik.Slika=="")
            {
                trenutni.Slika = trenutni.Slika;
            }
            else
            {
                trenutni.Slika = korisnik.Slika;
            }
            

            _context.Korisnik.Update(trenutni);
            _context.SaveChanges();
            korisnici = _context.Korisnik.ToList();
            return RedirectToAction("Dashboard");
        }
        public IActionResult DodavanjeProizvoda()
        {           
            return View("~/Views/Admin/DodajProizvod.cshtml");           
        }
        [HttpPost]
        public IActionResult DodajProizvod(Proizvod proizvod)
        {
            if (proizvodi == null)
                proizvodi = new List<Proizvod>();
            proizvodi = _context.Proizvod.ToList();
            proizvodi.Add(proizvod);
            _context.Proizvod.Add(proizvod);
            _context.SaveChanges();
            return View();
        }
        public IActionResult Verifikacija()
        {
            korisnici = _context.Korisnik.ToList();
            List<Korisnik> pomLista = new List<Korisnik>();
            foreach(var item in korisnici)
            {
                if(item.Tip==TipKorisnika.Dostavljac)
                {
                    //item.Verifikovan = StatusVerifikacije.PROCESIRA;
                    pomLista.Add(item);
                }
            }
            return View(pomLista);
        }
        //public void SendMail(string poruka, string emailPrimaoca)
        //{
        //    var email = new MimeMessage();
        //    email.From.Add(MailboxAddress.Parse("tyrique.kuhn4@ethereal.email"));
        //    email.To.Add(MailboxAddress.Parse(emailPrimaoca));
        //    email.Subject = "Verifikacija";
        //    email.Body = new TextPart("TextFormat.Html") { Text = poruka };

        //    using var smtp = new MailKit.Net.Smtp.SmtpClient();
        //    smtp.Connect("smtp.ethereal.email", 587, SecureSocetOptions.StartTls);
        //}
        public IActionResult OdobriDostavljaca(string email)
        {
            korisnici = _context.Korisnik.ToList();
            foreach(var item in korisnici)
            {
                if(item.Email==email)
                {
                    item.Verifikovan = StatusVerifikacije.PRIHVACEN;
                    _context.Korisnik.Update(item);
                    _context.SaveChanges();
                    break;
                }
            }
            
            return RedirectToAction("Verifikacija");
        }
        public IActionResult OdbijDostavljaca(string email)
        {
            korisnici = _context.Korisnik.ToList();
            foreach (var item in korisnici)
            {
                if (item.Email == email)
                {
                    item.Verifikovan = StatusVerifikacije.ODBIJEN;
                    _context.Korisnik.Update(item);
                    _context.SaveChanges();
                    break;
                }
            }
            return RedirectToAction("Verifikacija");
        }
        public IActionResult SvePorudzbine()
        {
            novaPorudzbina = _context.NovaPorudzbina.ToList();
            proizvodKolicina = _context.ProizvodKolicina.ToList();
            proizvodi = _context.Proizvod.ToList();

            foreach(var item in proizvodKolicina)
            {
                foreach(var item1 in proizvodi)
                {
                    if(item.ProizvodId==item1.Id)
                    {
                        item.Proizvod = item1;
                    }
                }
            }

            foreach(var item in novaPorudzbina)
            {
                if (item.Proizvod == null)
                    item.Proizvod = new List<ProizvodKolicina>();
                foreach(var item1 in proizvodKolicina)
                {
                    if(item1.Narudzbina==item.Id)
                    {
                        item.Proizvod.Add(item1);
                    }
                }
            }
            List<NovaPorudzbina> pomLista = new List<NovaPorudzbina>();
            foreach(var item in novaPorudzbina)
            {
                if(item.Status==StatusPorudzbine.DostavljaSe || item.Status==StatusPorudzbine.Dostavljeno)
                {
                    pomLista.Add(item);
                }
            }
            return View(pomLista);
        }
    }
}
