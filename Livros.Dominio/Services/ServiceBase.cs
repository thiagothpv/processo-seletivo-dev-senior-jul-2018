using Livros.Dominio.Interfaces.Repositorios;
using Livros.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Dominio.Services
{
    public class ServiceBase<T> : IDisposable, IServicesBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public void Adicionar(T obj)
        {
            _repository.Adicionar(obj);
        }

        public void Atualizar(T obj)
        {
            _repository.Atualizar(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public void Remove(T obj)
        {
            _repository.Remove(obj);
        }

        public IEnumerable<T> RetonaLista()
        {
            return _repository.RetonaLista();
        }

        public T RetornaPorId(int Id)
        {
            return _repository.RetornaPorId(Id);
        }
    }
}
