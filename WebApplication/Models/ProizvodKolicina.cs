using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class ProizvodKolicina
    {
        [Key]
        public int Id { get; set; }
        public int ProizvodId { get; set; }
        [NotMapped]
        public Proizvod Proizvod { get; set; }
        
        public int Kolicina { get; set; }
        public int Narudzbina { get; set; }

        //public ProizvodKolicina(Proizvod proizvod, int kolicina)
        //{
        //    Proizvod = proizvod;
        //    Kolicina = kolicina;
        //}
    }
}
