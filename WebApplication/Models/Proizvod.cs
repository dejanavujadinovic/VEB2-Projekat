using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Proizvod
    {        
        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }
        public float Cena { get; set; }
        public string Sastojci { get; set; }
        //public Proizvod(string ime, float cena, string sastojci)
        //{
        //    Ime = ime;
        //    Cena = cena;
        //    Sastojci = sastojci;
        //}
    }
}
