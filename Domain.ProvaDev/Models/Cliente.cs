using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ProvaDev.Models
{
    public partial class Cliente
    {
        public Cliente() { }

        public Cliente(Guid id, int idContato, int idEndereco, string nome, string sobrenome, string cpf, string rg)
        {
            Id = id;
            IdContato = idContato;
            IdEndereco = idEndereco;
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Rg = rg;
        }
               
        public Guid Id { get; private set; }

        public int IdContato { get; private set; }

        public int IdEndereco { get; private set; }

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string Cpf { get; private set; }

        public string Rg { get; private set; }

        public virtual Contato Contato { get; private set; }

        public virtual Endereco Endereco { get; private set; }

        public void AlterarEndereco(int idEndereco)
        {
            IdEndereco = idEndereco;
        }

        public void AlterarContato(int idContato)
        {
            IdContato = idContato;
        }
    }
}
