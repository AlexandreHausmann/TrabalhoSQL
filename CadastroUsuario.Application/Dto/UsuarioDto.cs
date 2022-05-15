namespace CadastroUsuario.Application.Dto
{
    public class UsuarioDto
    {
        public Guid Id { get; set; }

        public string Email { get; set; }
        public int CPF { get; set; }
        public string Password { get; set; }

        public UsuarioDto(Guid id, string email, int CPF, string password)
        {
            Id = id;
            Email = email;
            this.CPF = CPF;
            Password = password;
        }
    }
}
