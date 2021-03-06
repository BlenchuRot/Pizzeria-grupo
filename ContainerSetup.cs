using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Application;

namespace Pizzeria
{
    public class ContainerSetup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public static void ConfigureServices(IServiceCollection services)
        {


            services.AddScoped(typeof(IUserService), typeof(UserService));
            services.AddScoped(typeof(ICommentService), typeof(CommentService));
            services.AddScoped(typeof(IIngredientService), typeof(IngredientService));
            services.AddScoped(typeof(IPizzaService), typeof(PizzaService));
            services.AddScoped(typeof(IPizzaIngredientService), typeof(PizzaIngredientService));
        }
    }
}

