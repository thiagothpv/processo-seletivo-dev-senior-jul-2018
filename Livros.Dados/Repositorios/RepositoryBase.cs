using Livros.Dados.Contexto;
using Livros.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.infra.Dados.Repositorios
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {

        protected LivrosContext Context = new LivrosContext(); 

        public void Adicionar(T obj)
        {
            Context.Set<T>().Add(obj);
            Context.SaveChanges();
        }

        public void Atualizar(T obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Remove(T obj)
        {
            Context.Set<T>().Remove(obj);
        }

        public IEnumerable<T> RetonaLista()
        {
            return Context.Set<T>().ToList();
        }

        public T RetornaPorId(int Id)
        {
            return Context.Set<T>().Find(Id);
        }
    }
}
