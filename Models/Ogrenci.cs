using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataRelationExample.Models
{
    public class Ogrenci
    {
        [Key]
        public string TC { get; set; }
        [Required]
        public string AdSoyad { get; set; }
        public string Bolum { get; set; }
        public DateTime KursaBaslamaTarihi { get; set; }
        public string Telefon { get; set; }
        public virtual List<Grup> Grup { get; set; }
    }
}