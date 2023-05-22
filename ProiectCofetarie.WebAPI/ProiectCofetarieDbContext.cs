using ProiectCofetarie.Library.Models;
using System.Data.Entity;

namespace ProiectCofetarie.WebAPI
{
    public class ProiectCofetarieDbContext : System.Data.Entity.DbContext
    {
        public ProiectCofetarieDbContext()
            : base("ProiectCofetarieWebAPIContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Produs> Produs { get; set; }
        public DbSet<IstoricComenzi> IstoricComenzi { get; set; }
    }
}
