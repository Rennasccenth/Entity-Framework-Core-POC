using System;
using EF_Core_POC.Models.Entity;
using EF_Core_POC.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_Core_POC.Data
{
    public class RunAwayFromSerasaDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public RunAwayFromSerasaDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var mySqlStringConnection = _configuration.GetConnectionString("MySqlConnection");

            optionsBuilder.UseMySQL(mySqlStringConnection);
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