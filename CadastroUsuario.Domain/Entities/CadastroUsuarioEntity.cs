using CadastroUsuario.Domain.Entities;
using System;

namespace CadastroUsuario.Domain
{
    public class CadastroUsuarioEntity : EntityBase
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public CadastroUsuarioEntity(string nome, string sobrenome, string login, string password, string telefone, string endereco)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Endereco = endereco;
            Login = login;
            Password = password;
        }
    }
}
