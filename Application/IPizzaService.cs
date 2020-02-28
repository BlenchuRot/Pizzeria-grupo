
using Pizzeria.DTO;

namespace Pizzeria.Application
{
    public interface IPizzaService
    {
        PizzaRegistered Register(PizzaRegistration pizzaRegistration);
     
    }
}
