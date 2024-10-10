using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataRelationExample.Models
{
    public class EgitimDetayi
    {
        [Key,ForeignKey("Egitim")]
        public int EgitimId { get; set; }
        public string Mufredat { get; set; }
        public string KimlerKatilabilir { get; set; }
        public string BitirmeHakkinda { get; set; }
        public virtual Egitim Egitim { get; set; }
    }
}