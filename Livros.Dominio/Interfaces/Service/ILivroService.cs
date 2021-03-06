﻿using Livros.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Dominio.Services
{
    public interface ILivroService : IServicesBase<Livro>
    {
        IEnumerable<Livro> BuscarPorTitulo(string titulo);

        IEnumerable<Livro> BuscarPorGenero(string genero);

        IEnumerable<Livro> BuscarPorAutor(string autor);

        IEnumerable<Livro> BuscarPorAnoDePublicacao(int anoDePublicacao);

    }
}
