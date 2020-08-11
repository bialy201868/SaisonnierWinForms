namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model_new : DbContext
    {
        public Model_new()
            : base("name=Model_new")
        {
        }

        public virtual DbSet<agriculteur> agriculteurs { get; set; }
        public virtual DbSet<avantage> avantages { get; set; }
        public virtual DbSet<est_candidat> est_candidat { get; set; }
        public virtual DbSet<login> logins { get; set; }
        public virtual DbSet<niveau_autorisation> niveau_autorisation { get; set; }
        public virtual DbSet<proposition> propositions { get; set; }
        public virtual DbSet<region> regions { get; set; }
        public virtual DbSet<saisonnier> saisonniers { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<statut_candidat> statut_candidat { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<agriculteur>()
                .HasMany(e => e.propositions)
                .WithRequired(e => e.agriculteur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<agriculteur>()
                .HasMany(e => e.avantages)
                .WithMany(e => e.agriculteurs)
                .Map(m => m.ToTable("fournir_avantage", "saison").MapLeftKey("CODE_AGRI").MapRightKey("CODE_AVANTAGE"));

            modelBuilder.Entity<est_candidat>()
                .Property(e => e.DATE_CANDIDATURE)
                .HasPrecision(0);

            modelBuilder.Entity<login>()
                .HasMany(e => e.agriculteurs)
                .WithRequired(e => e.login)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<proposition>()
                .HasMany(e => e.est_candidat)
                .WithRequired(e => e.proposition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<proposition>()
                .HasMany(e => e.services)
                .WithMany(e => e.propositions)
                .Map(m => m.ToTable("contient_services", "saison").MapLeftKey("CODE_PROPOS").MapRightKey("CODE_SERVICE"));

            modelBuilder.Entity<region>()
                .HasMany(e => e.agriculteurs)
                .WithRequired(e => e.region)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<saisonnier>()
                .Property(e => e.SEXE)
                .IsFixedLength();

            modelBuilder.Entity<saisonnier>()
                .HasMany(e => e.est_candidat)
                .WithRequired(e => e.saisonnier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<statut_candidat>()
                .HasMany(e => e.est_candidat)
                .WithRequired(e => e.statut_candidat)
                .WillCascadeOnDelete(false);
        }
    }
}
