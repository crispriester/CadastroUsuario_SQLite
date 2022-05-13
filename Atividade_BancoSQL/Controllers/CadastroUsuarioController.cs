using CadastroUsuarios.Application.Dto;
using CadastroUsuarios.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace Atividade_BancoSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroUsuarioController : ControllerBase
    {
        private readonly ICadastroUsuarioService _cadastroUsuarioService;

        public CadastroUsuarioController(ICadastroUsuarioService cadastroUsuarioService)
        {
            _cadastroUsuarioService = cadastroUsuarioService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _cadastroUsuarioService.Get());
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _cadastroUsuarioService.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] InputCadastroUsuarioDto usuarioDto)
        {
            _cadastroUsuarioService.Add(usuarioDto);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            return Ok(_cadastroUsuarioService.Remove(id));
        }
    }
}
