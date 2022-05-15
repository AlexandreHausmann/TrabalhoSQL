using CadastroUsuario.Domain.Entities;
using CadastroUsuario.Infrastructure.Context;
using CadastroUsuario.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroUsuario.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryAsync<T> where T : EntityBase
    {
        protected readonly CadastroUsuarioContext _context;

        public RepositoryBase(CadastroUsuarioContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> Get()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByGuid(Guid id)
        {
            return await _context.Set<T>().FirstAsync(x => x.Id == id);
        }
    }
}
