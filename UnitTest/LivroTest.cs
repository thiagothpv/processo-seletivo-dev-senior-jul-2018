using Livros.Aplicacao.Interface;
using Livros.Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class LivroTest
    {

        private readonly ILivroAppService _livroApp;

     
        public LivroTest(ILivroAppService livroApp)
        {
            _livroApp = livroApp;
        }

        [TestMethod]
        public void SalvarLivroTest()
        {
            var livro = new Livro();

            livro.Autor = "Thiago";
            livro.DataDePublicacao = DateTime.Now.Date;
            livro.Editora = "Livre";
            livro.Genero = "Drama";
            livro.Paginas = 400;
            livro.Titulo = "O Grande Drama do Desenvolvimento de Curto Prazo";
            livro.Sinopse = "";
            livro.Descricao = "";
            livro.LinkDeCompra = "www.Saraiva.com.br";

            _livroApp.Adicionar(livro);

            var livroRetornado =_livroApp.BuscarPorTitulo(livro.Titulo);

            Assert.Equals(livro, livroRetornado);

        }
    }
}
