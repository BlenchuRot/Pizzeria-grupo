using Microsoft.EntityFrameworkCore;
using Pizzeria.Dominio;


//Se crea el dominio de usuario
namespace Pizzeria.Infraestructure
{
    //Creamos la clase BdContext
    //Configuramos BbContext, recopila los tipos de entidad y asigna el esquema de base de datos.
    public class PizzeriaContext : DbContext
    { 
         //DbSet no acepta valores NULL, por el cual nunca será null, pero le permite tener aceso a ellas.
        public DbSet<User> User { get; set; }
        //El constructor acepta un DBContextOptions.
        //BdContext tiene una instancia de DbContextOptions.
        public PizzeriaContext(DbContextOptions<PizzeriaContext> options) : base(options)
        {
        }
        //Usamos ModelBuilder para definir la entidad
        //Se reemplaza OnModelCreating por ModelBuilder para configurar el modelo sin modificar las clases de entidad.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserConfiguration.Apply(modelBuilder);
        }
    }
}