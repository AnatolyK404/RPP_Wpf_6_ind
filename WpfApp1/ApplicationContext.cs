using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1
{
    class ApplicationContext : DbContext
    {
        public DbSet<Deal> Deals { get; set; }
        public DbSet<DealType> DealTypes { get; set; }
        public DbSet<DealPlace> DealPlaces { get; set; }
        public DbSet<Currency> Currencys { get; set; }



        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; " +
            "Database=dealdb; Trusted_Connection=True;");
        }
    }
}
