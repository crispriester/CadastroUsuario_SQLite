using CadastroUsuario.Domain;
using Teste.Interfaces;
using CadastroUsuarios.Application.Dto;
using CadastroUsuarios.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios.Application.Services
{
    public class CadastroUsuarioService : ICadastroUsuarioService
    {
        private readonly ICadastroUsuarioRepository _repository;

        public CadastroUsuarioService(ICadastroUsuarioRepository repository)
        {
            _repository = repository;
        }

        public void Add(InputCadastroUsuarioDto usuarioDto)
        {
            var entidade = new CadastroUsuarioEntity(usuarioDto.Nome, usuarioDto.Sobrenome, usuarioDto.Login, usuarioDto.Password, usuarioDto.Telefone, usuarioDto.Endereco);

            _repository.Add(entidade);
        }

        public async Task<List<CadastroUsuarioDto>> Get()
        {
            var result = await _repository.Get();

            return result.Select(x => new CadastroUsuarioDto(x)).ToList();
        }

        public async Task<CadastroUsuarioDto> GetById(Guid id)
        {
            var result = await _repository.GetByGuid(id);

            return new CadastroUsuarioDto(result);
        }

        public async Task<string> Remove(Guid id)
        {
            var entity = await _repository.GetByGuid(id);

            var result = await _repository.Remove(entity);

            if (result == 0)
            {
                return "Ocorreu um erro ao remover o usuário.";
            }

            return "Usuário removido";
        }
    }
}
