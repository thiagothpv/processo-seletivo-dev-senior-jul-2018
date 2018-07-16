using Livros.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Livros.Dados.EntityConfig
{
    public class LivroConfiguration : EntityTypeConfiguration<Livro>
    {
        public LivroConfiguration()
        {
            HasKey(l => l.LivroId);

            Property(l => l.Titulo)
                .HasMaxLength(150)
                .IsRequired();

            Property(l => l.Genero)
                .HasMaxLength(150)
                .IsRequired();

            Property(l => l.DataDePublicacao)
                .IsRequired();

            Property(l => l.Paginas)
                .IsRequired();

            Property(l => l.Autor)
                .IsRequired()
                .HasMaxLength(150);

            Property(l => l.Sinopse)
               .IsRequired()
               .IsMaxLength();

            Property(l => l.Editora)
                .HasMaxLength(150)
                .IsRequired();

            Property(l => l.Descricao)
               .IsRequired()
               .HasMaxLength(250);
        }
    }
}
