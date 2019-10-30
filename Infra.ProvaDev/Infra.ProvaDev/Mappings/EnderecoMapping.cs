using Domain.ProvaDev.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.ProvaDev.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.IdUnidadeFederativa)
                .HasColumnName("idUnidadeFederativa");


            builder.Property(x => x.Logradouro)
                .HasColumnName("logradouro");

            builder.Property(x => x.Numero)
                .HasColumnName("numero");

            builder.Property(x => x.Cidade)
                .HasColumnName("cidade");

            builder.Property(x => x.Cep)
                .HasColumnName("cep");

            builder.Property(x => x.Complemento)
                .HasColumnName("complemento");

            builder.Property(x => x.Bairro)
                .HasColumnName("bairro");

            builder.ToTable("Endereco", "dbo");
        }
    }
}
