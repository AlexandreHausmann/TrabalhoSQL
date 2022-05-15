using CadastroUsuario.Domain.Entities;

namespace CadastroUsuario.Infrastructure.Interfaces
{
    public interface IUsuarioRepository : IRepositoryAsync<UsuarioEntity>
    {
        Task<UsuarioEntity> GetByLogin(UsuarioEntity usuario);
    }
}
