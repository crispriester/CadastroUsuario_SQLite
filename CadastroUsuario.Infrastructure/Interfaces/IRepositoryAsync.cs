using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.Infrastructure.Interfaces
{
    public interface IRepositoryAsync<T>
    {
        Task Add(T entity);

        Task<int> Remove(T entity);

        Task<List<T>> Get();

        Task<T> GetByGuid(Guid id);
    }
}
