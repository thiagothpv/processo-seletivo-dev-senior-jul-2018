using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Livros.MVC.ViewModels;
using Livros.Dominio.Entidades;

namespace Livros.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomaiToViewModelMapinngs"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Livro, LivroVO>();
        }
    }
}