using AutoMapper;
using Livros.Dominio.Entidades;
using Livros.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livros.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMapinngs"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<LivroVO, Livro>();
        }
    }
}