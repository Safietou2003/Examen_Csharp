using Microsoft.EntityFrameworkCore;
using CSHARP.Models;

namespace CSHARP.Db
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Livreur> Livreurs { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Paiement> Paiements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nom).IsRequired();
                entity.Property(e => e.Prenom).IsRequired();
                entity.Property(e => e.Telephone).IsRequired();
                entity.Property(e => e.Adresse).IsRequired();
                entity.Property(e => e.Solde).HasColumnType("decimal(18,2)");
                entity.HasMany(e => e.Commandes)
                      .WithOne(c => c.Client)
                      .HasForeignKey(c => c.ClientId);
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Libelle).IsRequired();
                entity.Property(e => e.QuantiteStock).IsRequired();
                entity.Property(e => e.PrixUnitaire).HasColumnType("decimal(18,2)");
                entity.Property(e => e.QuantiteSeuil).IsRequired();
                entity.Property(e => e.Images).HasMaxLength(255);
            });

            modelBuilder.Entity<Commande>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.Montant).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Statut).IsRequired();
            });

            modelBuilder.Entity<Livreur>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nom).IsRequired();
                entity.Property(e => e.Prenom).IsRequired();
                entity.Property(e => e.Telephone).IsRequired();
            });

            modelBuilder.Entity<Facture>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.Montant).HasColumnType("decimal(18,2)");
                entity.HasOne(e => e.Commande)
                      .WithOne(c => c.Facture)
                      .HasForeignKey<Facture>(e => e.CommandeId);
            });

            modelBuilder.Entity<Paiement>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Type).IsRequired();
                entity.Property(e => e.Montant).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Reference).IsRequired();
                entity.Property(e => e.Date).IsRequired();
                entity.HasOne(e => e.Facture)
                      .WithMany(f => f.Paiements)
                      .HasForeignKey(e => e.FactureId);
            });
        }
    }
}
