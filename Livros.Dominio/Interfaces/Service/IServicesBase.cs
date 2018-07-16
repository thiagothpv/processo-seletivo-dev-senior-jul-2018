using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Dominio.Services
{
    public interface IServicesBase<T> where T : class
    {
        void Adicionar(T obj);

        T RetornaPorId(int Id);

        IEnumerable<T> RetonaLista();

        void Atualizar(T obj);

        void Remove(T obj);

        void Dispose();
    }
}
