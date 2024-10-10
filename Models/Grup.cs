using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataRelationExample.Models
{
    public class Grup
    {
        [Key]
        public int GrupId { get; set; }
        public string GrupAdi { get; set; }
        public string Egitmeni { get; set; }
        public DateTime BaslangicTarihi { get; set; }

        public virtual Egitim Egitim { get; set; }
        public virtual List<Ogrenci> Ogrenci { get; set; }
    }
}