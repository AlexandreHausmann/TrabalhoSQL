using CadastroUsuario.Application.Dto;
using CadastroUsuario.Application.Interfaces;
using CadastroUsuario.Domain.Entities;
using CadastroUsuario.Infrastructure.Interfaces;

namespace CadastroUsuario.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }
        public void Add(string email, int CPF, string password)
        {
            var entidade = new UsuarioEntity(email, CPF, password);
            _repository.Add(entidade);
        }
        public async Task <bool> Retorno(string email, int CPF, string password)
        {
            var entidade = new UsuarioEntity(email, CPF, password);
            var usuarioEncontrado = await _repository.GetByLogin(entidade);
            if (usuarioEncontrado == null) return false;
            
            return true;
        }
    }
}
