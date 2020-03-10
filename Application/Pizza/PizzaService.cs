using Pizzeria.DTO;
using Pizzeria.Infraestructure;
using Pizzeria.Dominio;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Pizzeria.Application
{
    public class PizzaService : IPizzaService
    {
        private readonly PizzeriaContext _context;
        private readonly IPizzaIngredientService _pizzaIngredientService;
        public PizzaService(PizzeriaContext context, IPizzaIngredientService pizzaIngredientService)
        {
            _context = context;
            _pizzaIngredientService = pizzaIngredientService;
        }
       
        public void Create(CreatePizzaDTO pizzaRegistered)
        {
            var pizza = Pizza.Create(pizzaRegistered); //se crea nuevo Pizza.Registration
            _pizzaIngredientService.AddIngredients(pizza, pizzaRegistered.Ingredients); 
            _context.Pizza.Add(pizza);  //se descarga
            _context.SaveChanges(); //se guardan los cambios
            _context.Dispose();
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
          var pizza = _context.Pizza.Find();
          pizza.AddComment(comment); 

        }
         public void FindById(Guid id)
        {
            var pizza = _context.Pizza
                .AsNoTracking()
                .Include(p => p.Comments)
                .ThenInclude(c => c.User)
                .Include(p => p.PizzaIngredients)
                .ThenInclude(pi => pi.Ingredient)
                .SingleOrDefault(p => p.Id == id);
           // return pizza;
        }
    }
}