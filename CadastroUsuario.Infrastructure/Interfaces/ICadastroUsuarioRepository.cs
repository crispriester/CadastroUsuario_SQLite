using CadastroUsuario.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.Infrastructure.Interfaces
{
    public interface ICadastroUsuarioRepository : IRepositoryAsync<CadastroUsuarioEntity>
    {  }
}
