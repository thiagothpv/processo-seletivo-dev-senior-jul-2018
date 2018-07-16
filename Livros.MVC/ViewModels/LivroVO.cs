using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Livros.MVC.ViewModels
{
    public class LivroVO
    {
        [Key]
        public int LivroId { get; set; }

        [Required(ErrorMessage ="Preencha o campo Título")]
        [MaxLength(150, ErrorMessage ="Máximo {0} caracteres")]
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Gênero")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Gênero")]
        public string Genero { get; set; }
        
        [Required(ErrorMessage = "Preencha o campo data de publicação")]
        [DisplayName("Data de publicação")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato inválido")]
        public DateTime DataDePublicacao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Páginas")]
        [DisplayName("Páginas")]
        public int Paginas { get; set; }


        [Required(ErrorMessage = "Preencha o campo Autor")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        public string Autor { get; set; }


        [Required(ErrorMessage = "Preencha o campo Editora")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        public string Editora { get; set; }


        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sinopse")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        public string Sinopse { get; set; }

        
        [Url(ErrorMessage ="Preencha um Link válido")]
        [DisplayName("Site para comprar")]
        public string LinkDeCompra { get; set; }
    }
}