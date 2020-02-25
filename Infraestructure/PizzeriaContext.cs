using Microsoft.EntityFrameworkCore;
using Pizzeria.Dominio;

namespace Pizzeria.Infraestructure
{


    public class PizzeriaContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public PizzeriaContext(DbContextOptions<PizzeriaContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserConfiguration.Apply(modelBuilder);
        }
    }
}