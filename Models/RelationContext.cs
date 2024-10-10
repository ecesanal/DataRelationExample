using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataRelationExample.Models
{
    public class RelationContext:DbContext
    {
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<EgitimDetayi> EgitimDetayi { get; set; }
        public virtual DbSet<Egitim> Egitim { get; set; }
        public virtual DbSet<Grup> Grup { get; set; }
    }
}