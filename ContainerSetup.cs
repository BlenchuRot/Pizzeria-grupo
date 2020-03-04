using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pizzeria.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Application;

namespace Pizzeria
{
    public class ContinerSetup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<PizzeriaContext>(options => options.UseInMemoryDatabase("Lucia"));


            services.AddScoped(typeof(IUserService), typeof(UserService));
            services.AddScoped(typeof(ICommentService), typeof(CommentService));
            services.AddScoped(typeof(IIngredientService), typeof(IngredientService));
            services.AddScoped(typeof(IPizzaService), typeof(PizzaService));
        }
    }
}

