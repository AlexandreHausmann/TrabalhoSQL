using CadastroUsuario.Application.Dto;

namespace CadastroUsuario.Application.Interfaces
{
    public interface IUsuarioService
    {
        void Add(string email, int CPF, string password);

        Task<bool> Retorno(string email, int CPF, string password);
    }
}
