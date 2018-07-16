using Livros.Aplicacao.Interface;
using Livros.Dominio.Entidades;
using Livros.Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Aplicacao
{
    public class LivroAppService : AppServiceBase<Livro>, ILivroAppService
    {

        private readonly ILivroService _livroAppService;

        public LivroAppService(ILivroService livroAppService)
            : base(livroAppService)
        {
            _livroAppService = livroAppService;
        }

        public IEnumerable<Livro> BuscarPorAnoDePublicacao(int anoDePublicacao)
        {
            return _livroAppService.BuscarPorAnoDePublicacao(anoDePublicacao);
        }

        public IEnumerable<Livro> BuscarPorAutor(string autor)
        {
            return _livroAppService.BuscarPorAutor(autor);
        }

        public IEnumerable<Livro> BuscarPorGenero(string genero)
        {
            return _livroAppService.BuscarPorGenero(genero);
        }

        public IEnumerable<Livro> BuscarPorTitulo(string titulo)
        {
            return _livroAppService.BuscarPorTitulo(titulo);
        }
    }

}
