using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class PotrosacController : Controller
    {
        private readonly MyDbContext _context;
        private static List<Proizvod> proizvodi = new List<Proizvod>();
        private static List<NovaPorudzbina> novaPorudzbina = new List<NovaPorudzbina>();
        private static List<ProizvodKolicina> proizvodKolicina = new List<ProizvodKolicina>();
        private static List<TrenutnaPorudzbina> trenutna = new List<TrenutnaPorudzbina>();
        private static List<Korisnik> korisnici = new List<Korisnik>();

        //private static NovaPorudzbina NovaPorudzbina = new NovaPorudzbina();
        private static int kolicina = 0;

        public PotrosacController(MyDbContext context)
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
            if (korisnik.Slika == null || korisnik.Slika == "")
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
        public IActionResult NovaPorudzbina()
        {
            if (TempData["NemaPorudzbina"] == null) { TempData["NemaPorudzbina"] = ""; }
            ViewBag.Error = TempData["NemaPorudzbina"];
            return View(_context.Proizvod);
        }
        public IActionResult DodajProizvod(int id)
        {
            bool upisan = false;
            proizvodi = _context.Proizvod.ToList();
           
            foreach(var item in proizvodi)
            {
                if(item.Id==id)
                {
                    foreach(var item1 in proizvodKolicina)
                    {
                        //if (item1.Proizvod == null) { item1.Proizvod = new Proizvod(); }
                        if(item1.ProizvodId==item.Id)
                        {
                            item1.Proizvod = item;
                            item1.Kolicina++;
                            upisan = true;
                          
                        }
                    }
                    if (!upisan)
                    {
                        ProizvodKolicina pk = new ProizvodKolicina { ProizvodId = item.Id, Kolicina = 1, Proizvod=item };
                        proizvodKolicina.Add(pk);
                       
                        //_context.ProizvodKolicina.Add(pk);
                        //_context.SaveChanges();
                        break;
                    }
                }
            }
            //return View("~/Views/Potrosac/NovaPorudzbina.cshtml", proizvodi);
            return RedirectToAction("NovaPorudzbina");
        }
        public IActionResult MojaKorpa()
        {            
            return View(proizvodKolicina);
        }
        public IActionResult Poruci(float ukupno, string adresa, string komentar)
        {
            Korisnik kor = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            NovaPorudzbina np = new NovaPorudzbina { Proizvod = proizvodKolicina, Cena = ukupno, Adresa = adresa, Komentar = komentar, EmailPotrosaca=kor.Email };
            np.Status = StatusPorudzbine.NaCekanju;
            novaPorudzbina.Add(np);
            _context.NovaPorudzbina.Add(np);
            _context.SaveChanges();
            foreach(var item in proizvodKolicina)
            {
                item.Narudzbina = np.Id;
                //_context.ProizvodKolicina.Add(item);
                
            }
            foreach(var item in proizvodKolicina)
            {
                _context.ProizvodKolicina.Add(item);
                _context.SaveChanges();
            }
            _context.SaveChanges();
            proizvodKolicina = new List<ProizvodKolicina>();

            //return View("~/Views/Potrosac/Dashboard.cshtml", proizvodi);
            return RedirectToAction("Dashboard");
        }
        public IActionResult TrenutnaPorudzbina()
        {
            Korisnik trenutni = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            trenutna = _context.TrenutnaPorudzbina.ToList();
            novaPorudzbina = _context.NovaPorudzbina.ToList();
            
            proizvodi = _context.Proizvod.ToList();
            NovaPorudzbina np = new NovaPorudzbina();
            TimeSpan timeSpan = new TimeSpan();
            TempData["NemaPorudzbina"] = "";
            bool izadji = true;

            if (trenutna.Count == 0)
            {
                TempData["NemaPorudzbina"] = "Nemate aktivnih porudzbina, porucite novu porudzbinu!";
                return RedirectToAction("NovaPorudzbina");
            }
            for (int i = trenutna.Count - 1; i >= 0; i--)
            {                
                for (int j = novaPorudzbina.Count - 1; j >= 0; j--)
                {
                    if (trenutna[i].NarudzbinaId == novaPorudzbina[j].Id)
                    {
                        if (novaPorudzbina[j].EmailPotrosaca == trenutni.Email)
                        {
                            if (novaPorudzbina[j].Status == StatusPorudzbine.DostavljaSe)
                            {
                                if (trenutna[i].KrajnjeVreme < DateTime.Now)
                                {
                                    novaPorudzbina[j].Status = StatusPorudzbine.Dostavljeno;
                                    _context.NovaPorudzbina.Update(novaPorudzbina[j]);
                                    _context.SaveChanges();
                                }
                                else
                                {
                                    izadji = false;
                                }
                            }                            
                        }
                    }
                }
                
            }
            if (!izadji)
            {
                proizvodKolicina = _context.ProizvodKolicina.ToList();
                for (int i = trenutna.Count - 1; i >= 0; i--)
                {
                    for (int j = novaPorudzbina.Count - 1; j >= 0; j--)
                    {
                        if (trenutna[i].NarudzbinaId == novaPorudzbina[j].Id)
                        {
                            if (trenutna[i].KrajnjeVreme > DateTime.Now)
                            {
                                np = novaPorudzbina[j];
                                timeSpan = trenutna[i].KrajnjeVreme.Subtract(DateTime.Now);
                                ViewBag.Minuti = timeSpan;
                                //ViewBag.Sekunde = Convert.ToInt32((item.KrajnjeVreme - DateTime.Now).TotalSeconds);
                            }
                            //else
                            //{
                            //    proizvodKolicina = new List<ProizvodKolicina>();
                            //    TempData["NemaPorudzbina"] = "Nemate aktivnih porudzbina, porucite novu porudzbinu!";
                            //    return RedirectToAction("NovaPorudzbina");
                            //}
                        }
                    }
                }
                foreach (var item in proizvodKolicina)
                {
                    foreach (var item1 in proizvodi)
                    {
                        if (item.ProizvodId == item1.Id)
                        {
                            item.Proizvod = item1;
                        }
                    }
                }
                foreach (var item in novaPorudzbina)
                {
                    if (item.Proizvod == null) { item.Proizvod = new List<ProizvodKolicina>(); }
                    if (np.Id == item.Id)
                    {
                        foreach (var item1 in proizvodKolicina)
                        {
                            if (item1.Narudzbina == item.Id)
                            {
                                item.Proizvod.Add(item1);
                            }
                        }
                    }
                }
                proizvodKolicina = new List<ProizvodKolicina>();
                return View(np);
            }
            else
            {
                proizvodKolicina = new List<ProizvodKolicina>();
                TempData["NemaPorudzbina"] = "Nemate aktivnih porudzbina, porucite novu porudzbinu!";
                return RedirectToAction("NovaPorudzbina");
            }
        }
        public IActionResult PrethodnePorudzbine()
        {
            Korisnik trenutni = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            novaPorudzbina = _context.NovaPorudzbina.ToList();
            List<NovaPorudzbina> pomLista = new List<NovaPorudzbina>();

            proizvodKolicina = _context.ProizvodKolicina.ToList();
            proizvodi = _context.Proizvod.ToList();

            foreach (var item in proizvodKolicina)
            {
                foreach (var item1 in proizvodi)
                {
                    if (item.ProizvodId == item1.Id)
                    {
                        item.Proizvod = item1;
                    }
                }
            }

            foreach (var item in novaPorudzbina)
            {
                if (item.Proizvod == null)
                    item.Proizvod = new List<ProizvodKolicina>();
                foreach (var item1 in proizvodKolicina)
                {
                    if (item1.Narudzbina == item.Id)
                    {
                        item.Proizvod.Add(item1);
                    }
                }
            }
            trenutna = _context.TrenutnaPorudzbina.ToList();
            foreach (var item in novaPorudzbina)
            {
                if(item.EmailPotrosaca==trenutni.Email)
                {
                    if(item.Status==StatusPorudzbine.Dostavljeno)
                    {
                        pomLista.Add(item);
                    }
                    else if(item.Status==StatusPorudzbine.DostavljaSe)
                    {
                        foreach(var item1 in trenutna)
                        {
                            if(item1.NarudzbinaId == item.Id)
                            {
                                if (item1.KrajnjeVreme < DateTime.Now)
                                {
                                    pomLista.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            return View(pomLista);
        }
    }
}
