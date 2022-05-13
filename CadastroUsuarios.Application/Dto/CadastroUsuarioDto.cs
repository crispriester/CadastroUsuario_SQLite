using CadastroUsuario.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios.Application.Dto
{
    public class CadastroUsuarioDto
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public CadastroUsuarioDto(CadastroUsuarioEntity entidade)
        {
            Id = entidade.Id;
            Nome = entidade.Nome;
            Sobrenome = entidade.Sobrenome;
            Telefone = entidade.Telefone;
            Endereco = entidade.Endereco;
            Login = entidade.Login;
            Password = entidade.Password;
        }
    }
}
