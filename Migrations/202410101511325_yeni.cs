namespace DataRelationExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yeni : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Egitims",
                c => new
                    {
                        EgitimId = c.Int(nullable: false, identity: true),
                        EgitimAdi = c.String(),
                        EgitimTur = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EgitimId);
            
            CreateTable(
                "dbo.EgitimDetayis",
                c => new
                    {
                        EgitimId = c.Int(nullable: false),
                        Mufredat = c.String(),
                        KimlerKatilabilir = c.String(),
                        BitirmeHakkinda = c.String(),
                    })
                .PrimaryKey(t => t.EgitimId)
                .ForeignKey("dbo.Egitims", t => t.EgitimId)
                .Index(t => t.EgitimId);
            
            CreateTable(
                "dbo.Grups",
                c => new
                    {
                        GrupId = c.Int(nullable: false, identity: true),
                        GrupAdi = c.String(),
                        Egitmeni = c.String(),
                        BaslangicTarihi = c.DateTime(nullable: false),
                        Egitim_EgitimId = c.Int(),
                    })
                .PrimaryKey(t => t.GrupId)
                .ForeignKey("dbo.Egitims", t => t.Egitim_EgitimId)
                .Index(t => t.Egitim_EgitimId);
            
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        TC = c.String(nullable: false, maxLength: 128),
                        AdSoyad = c.String(nullable: false),
                        Bolum = c.String(),
                        KursaBaslamaTarihi = c.DateTime(nullable: false),
                        Telefon = c.String(),
                    })
                .PrimaryKey(t => t.TC);
            
            CreateTable(
                "dbo.OgrenciGrups",
                c => new
                    {
                        Ogrenci_TC = c.String(nullable: false, maxLength: 128),
                        Grup_GrupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogrenci_TC, t.Grup_GrupId })
                .ForeignKey("dbo.Ogrencis", t => t.Ogrenci_TC, cascadeDelete: true)
                .ForeignKey("dbo.Grups", t => t.Grup_GrupId, cascadeDelete: true)
                .Index(t => t.Ogrenci_TC)
                .Index(t => t.Grup_GrupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrenciGrups", "Grup_GrupId", "dbo.Grups");
            DropForeignKey("dbo.OgrenciGrups", "Ogrenci_TC", "dbo.Ogrencis");
            DropForeignKey("dbo.Grups", "Egitim_EgitimId", "dbo.Egitims");
            DropForeignKey("dbo.EgitimDetayis", "EgitimId", "dbo.Egitims");
            DropIndex("dbo.OgrenciGrups", new[] { "Grup_GrupId" });
            DropIndex("dbo.OgrenciGrups", new[] { "Ogrenci_TC" });
            DropIndex("dbo.Grups", new[] { "Egitim_EgitimId" });
            DropIndex("dbo.EgitimDetayis", new[] { "EgitimId" });
            DropTable("dbo.OgrenciGrups");
            DropTable("dbo.Ogrencis");
            DropTable("dbo.Grups");
            DropTable("dbo.EgitimDetayis");
            DropTable("dbo.Egitims");
        }
    }
}
