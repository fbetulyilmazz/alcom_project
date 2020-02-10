namespace Alcom.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Adres", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Ilce", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Il", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Kullanici", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rol", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.KargoBilgileri", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Kategori", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Urun", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MarkaBilgileri", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UrunOzellikleri", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Satis", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sepet", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SepetUrun", "KayitTarihi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SepetUrun", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sepet", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Satis", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UrunOzellikleri", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MarkaBilgileri", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Urun", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Kategori", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.KargoBilgileri", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rol", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Kullanici", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Il", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Ilce", "KayitTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Adres", "KayitTarihi", c => c.DateTime(nullable: false));
        }
    }
}
