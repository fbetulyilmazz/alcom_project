namespace Alcom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        IlceId = c.Int(nullable: false),
                        Aciklama = c.String(nullable: false, maxLength: 200),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ilce", t => t.IlceId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanici", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KullaniciId)
                .Index(t => t.IlceId);
            
            CreateTable(
                "dbo.Ilce",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IlId = c.Int(nullable: false),
                        Adi = c.String(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Il", t => t.IlId, cascadeDelete: true)
                .Index(t => t.IlId);
            
            CreateTable(
                "dbo.Il",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false),
                        PlakaKodu = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 20),
                        Soyad = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        Sifre = c.String(nullable: false),
                        KullaniciAdi = c.String(nullable: false, maxLength: 20),
                        DogumTarihi = c.DateTime(),
                        VarsayilanAdresId = c.Int(),
                        Durum = c.Int(nullable: false),
                        SonGirisZamani = c.DateTime(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Durum = c.Boolean(nullable: false),
                        Aciklama = c.String(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KargoBilgileri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirmaAdi = c.String(maxLength: 50),
                        Durumu = c.Int(nullable: false),
                        TeslimatAdresId = c.Int(nullable: false),
                        KargoTakipNo = c.String(),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adres", t => t.TeslimatAdresId, cascadeDelete: true)
                .Index(t => t.TeslimatAdresId);
            
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 50),
                        UstKategoriId = c.Int(),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategori", t => t.UstKategoriId)
                .Index(t => t.UstKategoriId);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriId = c.Int(nullable: false),
                        UrunKodu = c.Int(nullable: false),
                        MarkaId = c.Int(nullable: false),
                        UrunOzellikId = c.Int(nullable: false),
                        UrunAdi = c.String(nullable: false),
                        Fiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Durum = c.Int(nullable: false),
                        Stok = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategori", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.MarkaBilgileri", t => t.MarkaId, cascadeDelete: true)
                .ForeignKey("dbo.UrunOzellikleri", t => t.UrunOzellikId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.MarkaId)
                .Index(t => t.UrunOzellikId);
            
            CreateTable(
                "dbo.MarkaBilgileri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Durum = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UrunOzellikleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                        Durum = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Satis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SepetId = c.Int(nullable: false),
                        IndirimTutari = c.Decimal(precision: 18, scale: 2),
                        IndirimOrani = c.Double(),
                        SatisTutari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SatisDurumu = c.Int(nullable: false),
                        FaturaAdresiId = c.Int(nullable: false),
                        KargoId = c.Int(),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KargoBilgileri", t => t.KargoId)
                .ForeignKey("dbo.Sepet", t => t.SepetId, cascadeDelete: true)
                .Index(t => t.SepetId)
                .Index(t => t.KargoId);
            
            CreateTable(
                "dbo.Sepet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        ToplamTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanici", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.SepetUrun",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SepetId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sepet", t => t.SepetId, cascadeDelete: true)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.SepetId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.RolKullanici",
                c => new
                    {
                        Rol_Id = c.Int(nullable: false),
                        Kullanici_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Rol_Id, t.Kullanici_Id })
                .ForeignKey("dbo.Rol", t => t.Rol_Id, cascadeDelete: true)
                .ForeignKey("dbo.Kullanici", t => t.Kullanici_Id, cascadeDelete: true)
                .Index(t => t.Rol_Id)
                .Index(t => t.Kullanici_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SepetUrun", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.SepetUrun", "SepetId", "dbo.Sepet");
            DropForeignKey("dbo.Satis", "SepetId", "dbo.Sepet");
            DropForeignKey("dbo.Sepet", "KullaniciId", "dbo.Kullanici");
            DropForeignKey("dbo.Satis", "KargoId", "dbo.KargoBilgileri");
            DropForeignKey("dbo.Kategori", "UstKategoriId", "dbo.Kategori");
            DropForeignKey("dbo.Urun", "UrunOzellikId", "dbo.UrunOzellikleri");
            DropForeignKey("dbo.Urun", "MarkaId", "dbo.MarkaBilgileri");
            DropForeignKey("dbo.Urun", "KategoriId", "dbo.Kategori");
            DropForeignKey("dbo.KargoBilgileri", "TeslimatAdresId", "dbo.Adres");
            DropForeignKey("dbo.Adres", "KullaniciId", "dbo.Kullanici");
            DropForeignKey("dbo.RolKullanici", "Kullanici_Id", "dbo.Kullanici");
            DropForeignKey("dbo.RolKullanici", "Rol_Id", "dbo.Rol");
            DropForeignKey("dbo.Adres", "IlceId", "dbo.Ilce");
            DropForeignKey("dbo.Ilce", "IlId", "dbo.Il");
            DropIndex("dbo.RolKullanici", new[] { "Kullanici_Id" });
            DropIndex("dbo.RolKullanici", new[] { "Rol_Id" });
            DropIndex("dbo.SepetUrun", new[] { "UrunId" });
            DropIndex("dbo.SepetUrun", new[] { "SepetId" });
            DropIndex("dbo.Sepet", new[] { "KullaniciId" });
            DropIndex("dbo.Satis", new[] { "KargoId" });
            DropIndex("dbo.Satis", new[] { "SepetId" });
            DropIndex("dbo.Urun", new[] { "UrunOzellikId" });
            DropIndex("dbo.Urun", new[] { "MarkaId" });
            DropIndex("dbo.Urun", new[] { "KategoriId" });
            DropIndex("dbo.Kategori", new[] { "UstKategoriId" });
            DropIndex("dbo.KargoBilgileri", new[] { "TeslimatAdresId" });
            DropIndex("dbo.Ilce", new[] { "IlId" });
            DropIndex("dbo.Adres", new[] { "IlceId" });
            DropIndex("dbo.Adres", new[] { "KullaniciId" });
            DropTable("dbo.RolKullanici");
            DropTable("dbo.SepetUrun");
            DropTable("dbo.Sepet");
            DropTable("dbo.Satis");
            DropTable("dbo.UrunOzellikleri");
            DropTable("dbo.MarkaBilgileri");
            DropTable("dbo.Urun");
            DropTable("dbo.Kategori");
            DropTable("dbo.KargoBilgileri");
            DropTable("dbo.Rol");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Il");
            DropTable("dbo.Ilce");
            DropTable("dbo.Adres");
        }
    }
}
