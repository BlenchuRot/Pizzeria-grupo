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
        private readonly IEnumerable<Pizza> pizza;

        public PizzaService(PizzeriaContext context, IPizzaIngredientService pizzaIngredientService)
        {
            _context = context;
            _pizzaIngredientService = pizzaIngredientService;
        }
       
        public ReadPizzaDTO Create(CreatePizzaDTO pizzaRegistered)
        {
            var pizza = Pizza.Create(pizzaRegistered); //se crea nuevo Pizza.Registration
            _pizzaIngredientService.AddIngredients(pizza, pizzaRegistered.Ingredients); 
            _context.Pizza.Add(pizza);  //se descarga
            _context.SaveChanges(); //se guardan los cambios
            _context.Dispose();
             return ReadPizzaDTO.Create(pizza);
        }

        public void AddComment(Comment comment, Guid pizzaId)
        {
          var pizza = _context.Pizza.Find();
          pizza.AddComment(comment); 

        }
        public ReadPizzaDTO FindById(Guid id)
        {
            var pizza = _context.Pizza
                .AsNoTracking()
                .Include(p => p.Comments)
                .ThenInclude(c => c.User)
                .Include(p => p.PizzaIngredients)
                .ThenInclude(pi => pi.Ingredient)
                .SingleOrDefault(p => p.Id == id);

            var dto = new ReadPizzaDTO(){
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                Comments = pizza.Comments.Select(ReadCommentDTO.Create).ToList(),
                Ingredients = pizza.PizzaIngredients.Select(pi => ReadIngredientDTO.Create(pi.Ingredient)).ToList()
        
            };
               return dto;
        }

    
    }
}