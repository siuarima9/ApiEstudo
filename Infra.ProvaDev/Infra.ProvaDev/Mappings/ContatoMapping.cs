using Domain.ProvaDev.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.ProvaDev.Mappings
{
    public class ContatoMapping : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.Email)
                .HasColumnName("email");

            builder.Property(x => x.DddTelefone)
                .HasColumnName("dddTelefone");

            builder.Property(x => x.NumeroTelefone)
                .HasColumnName("numeroTelefone");

            builder.HasMany(x => x.Cliente)
                .WithOne(x => x.Contato)
                .HasForeignKey(x => x.IdContato);

            builder.ToTable("Contato", "dbo");
        }
    }
}
