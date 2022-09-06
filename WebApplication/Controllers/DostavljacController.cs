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
    public class DostavljacController : Controller
    {
        private readonly MyDbContext _context;
        private List<NovaPorudzbina> novaPorudzbina = new List<NovaPorudzbina>();
        private List<ProizvodKolicina> proizvodKolicina = new List<ProizvodKolicina>();
        private List<Proizvod> proizvodi = new List<Proizvod>();
        private List<TrenutnaPorudzbina> trenutna = new List<TrenutnaPorudzbina>();
        private static List<Korisnik> korisnici = new List<Korisnik>();
        public DostavljacController(MyDbContext context)
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
            if (TempData["NeaktivanDostavljac"] == null)
                TempData["NeaktivanDostavljac"] = "";
            ViewBag.Error = TempData["NeaktivanDostavljac"];
            novaPorudzbina = _context.NovaPorudzbina.ToList();
            proizvodKolicina = _context.ProizvodKolicina.ToList();
            proizvodi = _context.Proizvod.ToList();
            List<NovaPorudzbina> pomLista = new List<NovaPorudzbina>();

            foreach(var item in proizvodKolicina)
            {
                foreach(var item1 in proizvodi)
                {
                    if(item.ProizvodId==item1.Id)
                    {
                        item.Proizvod = item1;
                        break;
                    }
                }
            }
            foreach(var item in novaPorudzbina)
            {
                if (item.Proizvod == null)
                    item.Proizvod = new List<ProizvodKolicina>();
                if(item.Status==StatusPorudzbine.NaCekanju)
                {
                    foreach(var item1 in proizvodKolicina)
                    {
                        if(item1.Narudzbina==item.Id)
                        {
                            item.Proizvod.Add(item1);
                            
                        }
                    }
                    pomLista.Add(item);
                }
                
            }
            return View(pomLista);
        }
        public IActionResult PrihvatiNarudzbinu(int id)
        {
            novaPorudzbina = _context.NovaPorudzbina.ToList();
            trenutna = _context.TrenutnaPorudzbina.ToList();
            TrenutnaPorudzbina tp = new TrenutnaPorudzbina();
            Korisnik trenutni = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            TempData["NeaktivanDostavljac"] = "";
            for (int i = trenutna.Count-1; i >= 0; i--)
            {
                if (trenutna[i].EmailDostavljaca == trenutni.Email)
                {
                    for (int j = novaPorudzbina.Count-1; j >= 0; j--)
                    {
                        if(trenutna[i].NarudzbinaId==novaPorudzbina[j].Id)
                        {
                            if (novaPorudzbina[j].Status == StatusPorudzbine.DostavljaSe)
                            {
                                if (trenutna[i].KrajnjeVreme > DateTime.Now)
                                {
                                    TempData["NeaktivanDostavljac"] = "Ne mozete prihvatiti novu porudzbinu dok ne dostavite prethodnu!";
                                    return RedirectToAction("NovaPorudzbina");
                                }
                                if (trenutna[i].KrajnjeVreme < DateTime.Now)
                                {
                                    novaPorudzbina[j].Status = StatusPorudzbine.Dostavljeno;
                                    _context.NovaPorudzbina.Update(novaPorudzbina[j]);
                                    _context.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }
            if (trenutni.Verifikovan == StatusVerifikacije.PRIHVACEN)
            {
                foreach (var item in novaPorudzbina)
                {
                    if (item.Id == id)
                    {
                        Random rnd = new Random();
                        int minute = rnd.Next(2, 5);
                        tp.NarudzbinaId = item.Id;
                        tp.PocetnoVreme = DateTime.Now;
                        tp.KrajnjeVreme = tp.PocetnoVreme.AddMinutes(minute);
                        tp.EmailDostavljaca = trenutni.Email;
                        item.Status = StatusPorudzbine.DostavljaSe;

                        _context.TrenutnaPorudzbina.Add(tp);
                        _context.SaveChanges();
                        _context.NovaPorudzbina.Update(item);
                        _context.SaveChanges();

                        //return RedirectToAction("TrenutnaPorudzbina");
                    }
                }
                return RedirectToAction("TrenutnaPorudzbina");
            }
            else
            {
                TempData["NeaktivanDostavljac"] = "Nemate potrebnu verifikaciju za dostavljanje porudzbina!";
                return RedirectToAction("NovaPorudzbina");
            }
        }
        public IActionResult TrenutnaPorudzbina()
        {
            Korisnik trenutni = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            trenutna = _context.TrenutnaPorudzbina.ToList();
            novaPorudzbina = _context.NovaPorudzbina.ToList();
            proizvodKolicina = _context.ProizvodKolicina.ToList();
            proizvodi = _context.Proizvod.ToList();
            NovaPorudzbina np = new NovaPorudzbina();
            //var item = trenutna.Last();
            TimeSpan timeSpan = new TimeSpan();
            bool izadji = true;

            if(trenutna.Count == 0)
            {
                TempData["NeaktivanDostavljac"] = "Nemate aktivnih porudzbina, prihvatite novu porudzbinu!";
                return RedirectToAction("NovaPorudzbina");
            }
            for (int i = trenutna.Count - 1; i >= 0; i--)
            {
                if (trenutna[i].EmailDostavljaca == trenutni.Email)
                {
                    for (int j = novaPorudzbina.Count - 1; j >= 0; j--)
                    {
                        if (trenutna[i].NarudzbinaId == novaPorudzbina[j].Id)
                        {
                            
                            if (novaPorudzbina[j].Status == StatusPorudzbine.DostavljaSe)
                            {
                                np = novaPorudzbina[j];
                                izadji = false;
                                                        
                            }
                            //else
                            //{
                            //    izadji = true;
                            //    break;
                            //}
                        }
                    }
                }
                //if (izadji) break;
            }
            if (!izadji)
            {
                for (int i = trenutna.Count - 1; i >= 0; i--)
                {
                    if (trenutna[i].EmailDostavljaca == trenutni.Email)
                    {
                        if (trenutna[i].KrajnjeVreme > DateTime.Now)
                        {
                            timeSpan = trenutna[i].KrajnjeVreme.Subtract(DateTime.Now);
                            ViewBag.Minuti = timeSpan;
                            //ViewBag.Sekunde = Convert.ToInt32((item.KrajnjeVreme - DateTime.Now).TotalSeconds);
                        }
                        //else
                        //{
                        //    TempData["NeaktivanDostavljac"] = "Nemate aktivnih porudzbina, prihvatite novu porudzbinu!";
                        //    return RedirectToAction("NovaPorudzbina");
                        //}
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
                if (np.Proizvod == null) { np.Proizvod = new List<ProizvodKolicina>(); }
                foreach (var item in proizvodKolicina)
                {
                    if (item.Narudzbina == np.Id)
                    {
                        np.Proizvod.Add(item);
                    }
                }
                return View(np);
            }
            else
            {
                TempData["NeaktivanDostavljac"] = "Nemate aktivnih porudzbina, prihvatite novu porudzbinu!";
                return RedirectToAction("NovaPorudzbina");
            }
        }
        public IActionResult Isporuceno()
        {
            Korisnik trenutni = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));
            novaPorudzbina = _context.NovaPorudzbina.ToList();
            trenutna = _context.TrenutnaPorudzbina.ToList();

            for (int i = trenutna.Count - 1; i >= 0; i--)
            {
                if(trenutna[i].EmailDostavljaca==trenutni.Email)
                {
                    for (int j = novaPorudzbina.Count - 1; j >= 0; j--)
                    {
                        if (trenutna[i].NarudzbinaId == novaPorudzbina[j].Id)
                        {                            
                            novaPorudzbina[j].Status = StatusPorudzbine.Dostavljeno;
                            _context.NovaPorudzbina.Update(novaPorudzbina[j]);
                            _context.SaveChanges();
                            break;
                        }
                    }
                    break;
                }
            }
            return RedirectToAction("Dashboard", "Dostavljac");
        }
        public IActionResult MojePorudzbine()
        {
            trenutna = _context.TrenutnaPorudzbina.ToList();
            novaPorudzbina = _context.NovaPorudzbina.ToList();
            proizvodKolicina = _context.ProizvodKolicina.ToList();
            Korisnik trenutni = _context.Korisnik.Find(HttpContext.Session.GetString("Korisnik"));            
            List<TrenutnaPorudzbina> pomLista = new List<TrenutnaPorudzbina>();

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
            foreach(var item in trenutna)
            {
                foreach(var item1 in novaPorudzbina)
                {
                    if(item.NarudzbinaId==item1.Id)
                    {
                        if(item.KrajnjeVreme<DateTime.Now)
                        {
                            item1.Status = StatusPorudzbine.Dostavljeno;
                        }
                        item.novaPorudzbina = item1;
                    }
                }
            }

            foreach(var item in trenutna)
            {
                if(item.EmailDostavljaca == trenutni.Email)
                {
                    if(item.novaPorudzbina.Status==StatusPorudzbine.Dostavljeno)
                    {
                        pomLista.Add(item);
                    }
                    
                }
            }
            return View(pomLista);
        }
    }
}
