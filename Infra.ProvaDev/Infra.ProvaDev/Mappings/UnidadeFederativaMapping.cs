using Domain.ProvaDev.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.ProvaDev.Mappings
{
    public class UnidadeFederativaMapping : IEntityTypeConfiguration<UnidadeFederativa>
    {
        public void Configure(EntityTypeBuilder<UnidadeFederativa> builder)
        {
            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.Nome)
                .HasColumnName("nome");

            builder.Property(x => x.Sigla)
                .HasColumnName("sigla");

            builder.HasMany(x => x.Endereco)
                .WithOne(x => x.UnidadeFederativa)
                .HasForeignKey(x => x.IdUnidadeFederativa);

            builder.ToTable("UnidadeFederativa", "dbo");
        }
    }
}
