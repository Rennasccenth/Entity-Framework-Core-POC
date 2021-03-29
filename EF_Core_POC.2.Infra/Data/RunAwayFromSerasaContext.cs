using Nullnes.EF_Core_POC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Nullnes.EF_Core_POC.Infra.Data
{
    public class RunAwayFromSerasaContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public RunAwayFromSerasaContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_configuration.GetConnectionString("CurrentDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Guid);
                entity.Property(e => e.Owner)
                    .IsRequired();
                entity.Property(e => e.Balance)
                    .HasDefaultValue(0);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.Guid);
                entity.Property(e => e.Amount)
                    .IsRequired();
                entity.Property(e => e.Type)
                    .IsRequired();
                entity.Property(e => e.IsPlanned);

                // One to Many Relationship
                entity.HasOne(trans => trans.Account)
                    .WithMany(acc => acc.Transactions);
            });
        }
    }
}