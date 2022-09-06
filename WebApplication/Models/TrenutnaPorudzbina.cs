using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class TrenutnaPorudzbina
    {
        [Key]
        public int Id { get; set; }
        public int NarudzbinaId { get; set; }
        public DateTime PocetnoVreme { get; set; }
        public DateTime KrajnjeVreme { get; set; }
        public string EmailDostavljaca { get; set; }
        [NotMapped]
        public NovaPorudzbina novaPorudzbina { get; set; }
    }
}
