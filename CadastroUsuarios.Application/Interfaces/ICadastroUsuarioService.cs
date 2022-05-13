using CadastroUsuarios.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios.Application.Interfaces
{
    public interface ICadastroUsuarioService
    {
        void Add(InputCadastroUsuarioDto usuarioDto);

        Task<string> Remove(Guid id);

        Task<List<CadastroUsuarioDto>> Get();

        Task<CadastroUsuarioDto> GetById(Guid id);
    }
}
