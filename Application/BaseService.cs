using API.Infraestructure;
using System;
using Api.Application;

namespace Api.Application
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