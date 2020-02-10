namespace Alcom.DAL
{
    using Alcom.MODEL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class AlcomContext : DbContext
    {
        // Your context has been configured to use a 'AlcomContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Alcom.Entity.AlcomContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AlcomContext' 
        // connection string in the application configuration file.
        public AlcomContext()
            : base("name=AlcomContext")
        {
            //Database.SetInitializer<AlcomContext>(new CreateDatabaseIfNotExists<AlcomContext>());
            //Database.SetInitializer<AlcomContext>(new DropCreateDatabaseAlways<AlcomContext>());
            //Database.SetInitializer<AlcomContext>(new DropCreateDatabaseIfModelChanges<AlcomContext>());
            Database.SetInitializer<AlcomContext>(new MigrateDatabaseToLatestVersion<AlcomContext, Alcom.DAL.Migrations.Configuration>());

        }



        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Adres> Adres { get; set; }
         public virtual DbSet<Il> Il { get; set; }
         public virtual DbSet<Ilce> Ilce { get; set; }
         public virtual DbSet<KargoBilgileri> KargoBilgileri { get; set; }
         public virtual DbSet<Kategori> Kategori { get; set; }
         public virtual DbSet<Kullanici> Kullanici { get; set; }
         public virtual DbSet<MarkaBilgileri> MarkaBilgileri { get; set; }
         public virtual DbSet<Rol> Rol { get; set; }
         public virtual DbSet<Satis> Satis { get; set; }
         public virtual DbSet<SepetUrun> SepetUrun { get; set; }
         public virtual DbSet<Urun> Urun { get; set; }
         public virtual DbSet<Sepet> Sepet { get; set; }
         public virtual DbSet<UrunOzellikleri> UrunOzellikleri { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }

   
}