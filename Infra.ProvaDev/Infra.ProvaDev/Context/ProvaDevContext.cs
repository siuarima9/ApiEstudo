using Domain.ProvaDev.Models;
using Infra.ProvaDev.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infra.ProvaDev.Context
{
    public partial class ProvaDevContext : DbContext
    {
        public ProvaDevContext()
            : base()
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Contato> Contatos { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<UnidadeFederativa> UnidadesFederativa { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new ContatoMapping());
            modelBuilder.ApplyConfiguration(new EnderecoMapping());
            modelBuilder.ApplyConfiguration(new UnidadeFederativaMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.15.16;Database=ProvaDev;User Id=usr_prova;Password=ma9");
        }

    }
}
