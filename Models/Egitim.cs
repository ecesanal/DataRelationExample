using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataRelationExample.Models
{
    public enum EgitimTur
    {
        Bireysel,
        IsOrtakligi
    }
    public class Egitim
    {
        [Key]
        public int EgitimId { get; set; }
        public string EgitimAdi { get; set; }
        public EgitimTur EgitimTur { get; set; }
        public virtual EgitimDetayi EgitimDetayi { get; set; }
        public virtual List<Grup> Grup { get; set; }
    }
}