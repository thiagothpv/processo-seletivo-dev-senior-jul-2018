using Livros.Dominio.Entidades;
using Livros.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Dominio.Services
{
     public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
            : base(livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IEnumerable<Livro> BuscarPorAnoDePublicacao(int anoDePublicacao)
        {
            return _livroRepository.BuscarPorAnoDePublicacao(anoDePublicacao);
        }

        public IEnumerable<Livro> BuscarPorAutor(string autor)
        {
            return _livroRepository.BuscarPorAutor(autor);
        }

        public IEnumerable<Livro> BuscarPorGenero(string genero)
        {
            return _livroRepository.BuscarPorGenero(genero);
        }

        public IEnumerable<Livro> BuscarPorTitulo(string titulo)
        {
            return _livroRepository.BuscarPorTitulo(titulo);
        }
    }
}
