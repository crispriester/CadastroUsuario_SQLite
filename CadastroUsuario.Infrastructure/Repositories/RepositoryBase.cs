using CadastroUsuario.Domain.Entities;
using CadastroUsuario.Infrastructure.Context;
using CadastroUsuario.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.Infrastructure.Repositories
{
    //public class RepositoryBase<T> : IRepositoryAsync<T> where T : EntityBase
    //{
    //    private readonly CadastroUsuarioContext _context;

    //    public RepositoryBase(CadastroUsuarioContext context)
    //    {
    //        _context = context;
    //    }

        //public async Task Add(T entity)
        //{
        //    await _context.Set<T>().AddAsync(entity);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<List<T>> Get()
        //{
        //    return await _context.Set<T>().ToListAsync();
        //}

        //public async Task<T> GetByGuid(Guid id)
        //{
        //    return await _context.Set<T>().FirstAsync(x => x.Id == id);
        //}

        //public async Task Delete(Guid id)
        //{
        //    await _context.Delete<T>().FirstAsync(x => x.Id == id);
        //    await _context.SaveChangesAsync();
        //}
    //}
}
