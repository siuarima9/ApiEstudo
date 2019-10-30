using Domain.ProvaDev.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.ProvaDev.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.IdContato)
                .HasColumnName("idContato");

            builder.Property(x => x.Nome)
                .HasColumnName("nome");

            builder.Property(x => x.Sobrenome)
                .HasColumnName("sobrenome");

            builder.Property(x => x.Cpf)
                .HasColumnName("cpf");

            builder.Property(x => x.Rg)
                .HasColumnName("rg");

            builder.HasOne(x => x.Contato)
                .WithMany(x => x.Cliente)
                .HasForeignKey(x => x.IdContato);

            builder.HasOne(x => x.Endereco)
                .WithMany(x => x.Cliente)
                .HasForeignKey(x => x.IdEndereco);

            builder.ToTable("Cliente", "dbo");
        }
    }
}
