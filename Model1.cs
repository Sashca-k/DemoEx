namespace Sashca
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<Izdelie> Izdelie { get; set; }
        public virtual DbSet<PrimerZakaz> PrimerZakaz { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Ukrashenia> Ukrashenia { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredients>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Izdelie>()
                .Property(e => e.Cost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Izdelie>()
                .HasMany(e => e.PrimerZakaz)
                .WithRequired(e => e.Izdelie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ukrashenia>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Ukrashenia>()
                .Property(e => e.Ves)
                .IsFixedLength();

            modelBuilder.Entity<Ukrashenia>()
                .HasMany(e => e.Ingredients)
                .WithOptional(e => e.Ukrashenia)
                .HasForeignKey(e => e.Artikula);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Izdelie)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.MenegerLogin);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Izdelie1)
                .WithRequired(e => e.Users1)
                .HasForeignKey(e => e.ZakazLogin)
                .WillCascadeOnDelete(false);
        }
    }
}
