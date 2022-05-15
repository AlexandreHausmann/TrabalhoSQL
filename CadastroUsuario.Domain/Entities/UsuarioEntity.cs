namespace CadastroUsuario.Domain.Entities
{
    public class UsuarioEntity : EntityBase
    {
        public string Email { get; set; }
        public int CPF { get; set; }
        public string Password { get; set; }
        public UsuarioEntity(string email, int CPF, string password)
        {
            Email = email;
            this.CPF = CPF;
            Password = password;
        }
    }
}