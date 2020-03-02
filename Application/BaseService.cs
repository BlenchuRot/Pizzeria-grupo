using Pizzeria.Infraestructure;
using System;

namespace Pizzeria.Application
{
    class BaseService : IDisposable
    {
        private readonly IUnitOfWork _uow;
        public BaseService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
        

    }

   
}