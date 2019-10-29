using System.Data.Entity;
using Domain.ProvaDev.Models;

namespace Infra.ProvaDev.Context
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Contato> Contatos { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<UnidadeFederativa> UnidadesFederativa { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.sobrenome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.rg)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.dddTelefone)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.numeroTelefone)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .HasMany(e => e.Cliente)
                .WithRequired(e => e.Contato)
                .HasForeignKey(e => e.idContato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.cep)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.logradouro)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.numero)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .HasMany(e => e.Cliente)
                .WithRequired(e => e.Endereco)
                .HasForeignKey(e => e.idEndereco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnidadeFederativa>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<UnidadeFederativa>()
                .Property(e => e.sigla)
                .IsUnicode(false);

            modelBuilder.Entity<UnidadeFederativa>()
                .HasMany(e => e.Endereco)
                .WithRequired(e => e.UnidadeFederativa)
                .HasForeignKey(e => e.idUnidadeFederativa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.senha)
                .IsUnicode(false);
        }
    }
}
