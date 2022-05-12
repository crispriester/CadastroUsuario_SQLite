using CadastroUsuario.Domain;
using CadastroUsuario.Infrastructure.Interfaces;
using CadastroUsuarios.Application.Dto;
using CadastroUsuarios.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios.Application.Services
{
    //public class CadastroUsuarioService : ICadastroUsuarioService
    //{
    //    private readonly ICadastroUsuarioRepository _repository;

    //    public CadastroUsuarioService(ICadastroUsuarioRepository repository)
    //    {
    //        _repository = repository;
    //    }

    //    public void Add(InputCadastroUsuarioDto usuarioDto)
    //    {
    //        var entidade = new CadastroUsuarioEntity(usuarioDto.Nome, usuarioDto.Sobrenome, usuarioDto.Login, usuarioDto.Password, usuarioDto.Telefone, usuarioDto.Endereco);

    //        _repository.Add(entidade);
    //    }

    //    public async Task<List<CadastroUsuarioDto>> Get()
    //    {
    //        var result = await _repository.Get();

    //        return result.Select(x => new CadastroUsuarioDto(x.Id, x.Login, x.Password)).ToList();
    //    }

    //    public async Task<CadastroUsuarioDto> GetById(Guid id)
    //    {
    //        var result = await _repository.GetByGuid(id);

    //        return new CadastroUsuarioDto(result.Id, result.Login, result.Password);
    //    }

    //    public string GetById(Guid id)
    //    {
    //        var result = _repository.Delete(id);

    //        if (result != null)
    //        {
    //            return "Usuário deletado.";
    //        }

    //        return "Deu erro.";
    //    }
    //}
}
