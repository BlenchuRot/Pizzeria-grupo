using Pizzeria.DTO;

namespace Pizzeria.Application
{
    class IngredienteService : IIngredienteService
    {
        private readonly IngredienteContext _context;
        public IngredienteService(IngredienteContext context)
        {
            _context = context;
        }

        public IngredienteRegistered Register(IngredienteRegistration ingredienteRegistration)
        {
            var ingrediente = ingrediente.Create(ingredienteRegistration); //se crea nuevo Ingrediente.Registration
            _context.ingrediente.Add(ingrediente);  //se descarga
            _context.SaveChanges(); //se guardan los cambios
            _context.Dispose();
            return ingredienteRegistered.Create(ingrediente); //devuelve el usuario creado
        }
    }
}