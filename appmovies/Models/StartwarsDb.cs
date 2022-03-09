using Microsoft.EntityFrameworkCore;
using appmovies.Models;

namespace appmovies.Models
{
    public class StartwarsDb : DbContext
    {
        public DbSet<Personaje> Personajes { get; set; }
        public StartwarsDb()
        {
        }
        public StartwarsDb(DbContextOptions<StartwarsDb> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("Startwars");
               //optionsBuilder.UseSqlServer("Server=.;Database=Startwars;Trusted_Connection=True");
            
            }
        }
    }
}
