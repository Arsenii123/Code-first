
using Homework5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Infrastructure
{
    public class AppDbContext : DbContext
    {


        public AppDbContext() : base()
        {
        }
        public DbSet<Sport> Sport => Set<Sport>();
        public DbSet<Trainer> Trainer => Set<Trainer>();
        public DbSet<Team> Team => Set<Team>();
        public DbSet<Player> Player => Set<Player>();
        public DbSet<Squad> Squads => Set<Squad>();
        // налаштування підключення до бази даних
        // викликається при створенні контексту
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }

    }
}
