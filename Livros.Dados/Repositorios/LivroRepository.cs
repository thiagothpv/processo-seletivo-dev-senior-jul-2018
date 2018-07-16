using Livros.Dominio.Entidades;
using Livros.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.infra.Dados.Repositorios
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        public IEnumerable<Livro> BuscarPorAnoDePublicacao(int anoDePublicacao)
        {
            return Context.Livros.Where(l => l.DataDePublicacao.Year == anoDePublicacao);
        }

        public IEnumerable<Livro> BuscarPorAutor(string autor)
        {
            return Context.Livros.Where(l => l.Autor == autor);
        }

        public IEnumerable<Livro> BuscarPorGenero(string genero)
        {
            return Context.Livros.Where(l => l.Genero == genero);
        }

        public IEnumerable<Livro> BuscarPorTitulo(string titulo)
        {
            return Context.Livros.Where(l => l.Titulo == titulo);

        }
    }
}
