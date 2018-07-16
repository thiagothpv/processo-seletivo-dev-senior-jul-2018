using System;

namespace Livros.Dominio.Entidades
{
    public class Livro
    {
        public int LivroId { get; set; }

        public string Titulo { get; set; }

        public string Genero { get; set; }

        public DateTime DataDePublicacao { get; set; }

        public int Paginas { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public string Descricao { get; set; }

        public string Sinopse { get; set; }

        public string LinkDeCompra { get; set; }
    }
}
