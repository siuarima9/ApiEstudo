using Domain.ProvaDev.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.ProvaDev.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.Nome)
                .HasColumnName("nome");

            builder.Property(x => x.Senha)
                .HasColumnName("senha");

            builder.Property(x => x.Ativo)
                .HasColumnName("ativo");

            builder.ToTable("Usuario", "dbo");
        }
    }
}
