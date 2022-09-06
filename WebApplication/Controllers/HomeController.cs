using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Models;


namespace WebApplication.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;
        private static List<Korisnik> korisnici = new List<Korisnik>();

        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
            korisnici = _context.Korisnik.ToList();
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Account()
        {
            return RedirectToAction("GoogleLogin", "Account");
        }
        [HttpPost]
        public IActionResult Prijava(string email, string lozinka)
        {
            Korisnik korisnik = _context.Korisnik.Find(email);
            ViewBag.Error = "";
            foreach (var item in korisnici)
            {
                if(item.Email==email && item.Lozinka==lozinka)
                {                    
                    HttpContext.Session.SetString("Korisnik", email);
                    Korisnik kor = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));

                    if(kor.Tip==TipKorisnika.Administrator)
                    {
                        return RedirectToAction("Dashboard", "Admin");
                    }
                    else if(kor.Tip == TipKorisnika.Potrosac)
                    {
                        return RedirectToAction("Dashboard", "Potrosac");
                    }
                    else if (kor.Tip == TipKorisnika.Dostavljac)
                    {
                        return RedirectToAction("Dashboard", "Dostavljac");
                    }
                    
                }
            }
            ViewBag.Error = "Neispravan email ili lozinka!";
            return View("Index");
        }
       
        public IActionResult NaRegistrovanje()
        {
            return View("Registracija");
        }
        [HttpPost]
        public IActionResult Registracija(Korisnik korisnik, string lozinka2)
        {
            if(korisnik.Lozinka == lozinka2)
            {
                if (korisnik.Tip == TipKorisnika.Dostavljac)
                {
                    korisnik.Verifikovan = StatusVerifikacije.PROCESIRA;
                    korisnici.Add(korisnik);
                    _context.Korisnik.Add(korisnik);
                    _context.SaveChanges();
                    return View("Index");
                    //return RedirectToAction("Verifikacija", "Admin");
                }
                else
                {
                    korisnik.Verifikovan = StatusVerifikacije.BEZVERIFIKACIJE;
                    korisnici.Add(korisnik);
                    _context.Korisnik.Add(korisnik);
                    _context.SaveChanges();
                    return View("Index");
                }
            }
            else
            {
                ViewBag.Error = "Neispravna lozinka!";
                return View();
            }
            
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        //public IActionResult GooglePrijava()
        //{
            
        //}
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
            if (korisnik.Slika == null || korisnik.Slika == "")
                trenutni.Slika = trenutni.Slika;
            else
                trenutni.Slika = korisnik.Slika;

            _context.Korisnik.Update(trenutni);
            _context.SaveChanges();
            korisnici = _context.Korisnik.ToList();
            return RedirectToAction("Dashboard");
        }
        public IActionResult DodavanjeProizvoda()
        {
            Korisnik korisnik = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            if(korisnik.Tip==TipKorisnika.Administrator)
            {
                return View("~/Views/Admin/DodajProizvod.cshtml");
            }
            return RedirectToAction("NemaPristup");
        }
        public IActionResult NemaPristup()
        {
            return View();
        }
        public IActionResult NovaPorudzbina()
        {
            Korisnik korisnik = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            if (korisnik.Tip == TipKorisnika.Potrosac)
            {
                return View("~/Views/Potrosac/NovaPorudzbina.cshtml", _context.Proizvod);
            }
            return RedirectToAction("NemaPristup");
        }
        public IActionResult Verifikacija()
        {
            Korisnik korisnik = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            if (korisnik.Tip == TipKorisnika.Administrator)
            {
                return RedirectToAction("Verifikacija", "Admin");
            }
            return RedirectToAction("NemaPristup");
        }
        public IActionResult NovePorudzbineDostavljac()
        {
            Korisnik korisnik = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            if (korisnik.Tip == TipKorisnika.Dostavljac)
            {
                return RedirectToAction("NovaPorudzbina", "Dostavljac");
            }
            return RedirectToAction("NemaPristup");
        }
        public IActionResult TrenutnaPorudzbina()
        {
            Korisnik korisnik = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            if (korisnik.Tip == TipKorisnika.Dostavljac)
            {
                return RedirectToAction("TrenutnaPorudzbina", "Dostavljac");
            }
            else if (korisnik.Tip == TipKorisnika.Potrosac)
            {
                return RedirectToAction("TrenutnaPorudzbina", "Potrosac");
            }
            return RedirectToAction("NemaPristup");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
