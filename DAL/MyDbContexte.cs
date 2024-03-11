using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;


namespace DAL
{
    public class MyDbContexte : DbContext
    {
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Produit> Produits { get; set; }
        
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
              (@"Data Source=Localhost\TEST;Initial Catalog=PERIF;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }

    }
}
