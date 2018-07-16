using Livros.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Aplicacao.Interface
{
    public interface ILivroAppService: IAppServiceBase<Livro>
    {
        IEnumerable<Livro> BuscarPorAnoDePublicacao(int anoDePublicacao);
        
        IEnumerable<Livro> BuscarPorAutor(string autor);

        IEnumerable<Livro> BuscarPorGenero(string genero);

        IEnumerable<Livro> BuscarPorTitulo(string titulo);
        
    }
}
