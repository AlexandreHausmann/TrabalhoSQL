using CadastroUsuario.Domain.Entities;
using CadastroUsuario.Infrastructure.Context;
using CadastroUsuario.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroUsuario.Infrastructure.Repositories
{
    public class UsuarioRepository : RepositoryBase<UsuarioEntity>, IUsuarioRepository
    {
        public UsuarioRepository(CadastroUsuarioContext context) : base(context)
        {
           
        }
        public async Task<UsuarioEntity> GetByLogin(UsuarioEntity usuario)
        {
            return await _context.Set<UsuarioEntity>().FirstOrDefaultAsync(x => x.CPF == usuario.CPF && x.Email == usuario.Email && x.Password == usuario.Password);
        }
    }
}
