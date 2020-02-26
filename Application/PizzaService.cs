using Pizzeria.DTO;

namespace Pizzeria.Application
{
    class PizzaService : IPizzaService
    {
        private readonly PizzaContext _context;
        public PizzaService(PizzaContext context)
        {
            _context = context;
        }

        public PizzaRegistered Register(PizzaRegistration pizzaRegistration)
        {
            var Pizza = pizza.Create(pizzaRegistration); //se crea nuevo Pizza.Registration
            _context.pizza.Add(pizza);  //se descarga
            _context.SaveChanges(); //se guardan los cambios
            _context.Dispose();
            return PizzaRegistered.Create(pizza); //devuelve el usuario creado
        }
    }
}