using Livros.Aplicacao.Interface;
using Livros.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Aplicacao
{
    public class AppServiceBase<T> : IDisposable, IAppServiceBase<T> where T : class
    {
        private ILivroAppService livroAppService;
        private readonly IServicesBase<T> _serviceBase;

        public AppServiceBase(ILivroAppService livroAppService)
        {
            this.livroAppService = livroAppService;
        }

        public AppServiceBase(IServicesBase<T> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Adicionar(T obj)
        {
            _serviceBase.Adicionar(obj);
        }

        public void Atualizar(T obj)
        {
            _serviceBase.Atualizar(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public void Remove(T obj)
        {
            _serviceBase.Remove(obj);
        }

        public IEnumerable<T> RetonaLista()
        {
            return _serviceBase.RetonaLista();
        }

        public T RetornaPorId(int Id)
        {
            return _serviceBase.RetornaPorId(Id);
        }
    }
}
