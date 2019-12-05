using BLL;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Produkt> Produkt { get; set; }
        public DatabaseContext()
        {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  // Erstellen der Datenbank
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder
        .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyFoody;Trusted_Connection=True;");

    }
}
