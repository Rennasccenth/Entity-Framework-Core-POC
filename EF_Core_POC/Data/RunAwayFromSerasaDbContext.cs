using System;
using EF_Core_POC.Models.Entity;
using EF_Core_POC.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_Core_POC.Data
{
    public class RunAwayFromSerasaDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public RunAwayFromSerasaDbContext(RunAwayFromSerasaSettings settings)
        {
            _settings = settings;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var configurationRoot = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{envName}.json")
                .Build();

            optionsBuilder.UseMySQL("server=localhost");
        }
    }
}