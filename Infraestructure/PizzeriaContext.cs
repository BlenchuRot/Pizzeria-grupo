using Microsoft.EntityFrameworkCore;
using  Api.Dominio;
namespace Pizzeria.Infraestructure {


 public class PizzeriaContext : DbContext { 
    public DbSet<User> User {get; set;}
   public PizzeriaContext(DbContextOptions<PizzeriaContext> options) : base(options){
   }
    
 }
}