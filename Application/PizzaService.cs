using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using Pizzeria.Dominio;
using System;

namespace Pizzeria.Application
{

    class pizzaService 
        {
            private readonly PizzeriaContext _context;
            public pizzaService(PizzeriaContext context)
            {
                _context = context;
            
            }
            public PizzaRegistered Register(PizzaRegistration pizzaRegistration)
            {
                var pizza = Pizza.Create(pizzaRegistration); //se crea nuevo Pizza.Registration
                _context.Pizza.Add(Name);  //se descarga
                _context.SaveChanges(); //se guardan los cambios
                _context.Dispose();
                return PizzaRegistered.Create(pizza); 
            }
              public Pizza BuscarPorId(Guid id){
              return _context.Pizza.Find(id);
        } 



    }
}