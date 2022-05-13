using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Repositories
{
    public class CadastroUsuarioRepository : RepositoryBase<CadastroUsuarioEntity>, ICadastroUsuarioRepository
    {
        public CadastroUsuarioRepository(CadastroUsuarioContext context) : base(context)
        {
        }
    }
}
