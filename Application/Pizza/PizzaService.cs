using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using Pizzeria.Dominio;
using System;

namespace Pizzeria.Application
{
    public class PizzaService : IPizzaService
    {
        private readonly PizzeriaContext _context;
        public PizzaService(PizzeriaContext context)
        {
            _context = context;
        }
        public CreatePizzaDTO Create(CreatePizzaDTO pizzaRegistered)
        {
            var pizza = Pizza.Create(pizzaRegistered); //se crea nuevo Pizza.Registration
            _context.Pizza.Add(pizza);  //se descarga
            _context.SaveChanges(); //se guardan los cambios
            _context.Dispose();
            return CreatePizzaDTO.Create(pizza);
        }
        public Pizza GetById(Guid id)
        {
            return _context.Pizza.Find(id);
        }
        public Pizza FindAll()
        {
            return _context.Pizza.Find();
        }
        public void AddComment(Comment comment, Guid pizzaId)
        {

        }
    }
}