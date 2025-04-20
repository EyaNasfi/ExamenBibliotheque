using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var _connectionString = @"server=localhost;database=BiblioNasfiEya;uid=root;password=;";
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PretConfig());
            modelBuilder.ApplyConfiguration(new CategorieConfig());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            //modelBuilder.Entity<Staff>().ToTable("Staffs");
            //modelBuilder.Entity<Traveller>().ToTable("Travellers");
            //modelBuilder.Entity<Plane>().HasKey(p => p.PlaneId);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //configurationBuilder.Properties<DateTime>()
            //    .HaveColumnType("date");
        }


        public DbSet<PretLivre> prets { get; set; }
        public DbSet<Livre> livres { get; set; }
        public DbSet<Abonne> Abonnes { get; set; }
        public DbSet<Categorie> categories { get; set; }
        //public DbSet<Staff> Staff { get; set; }

    }
}
