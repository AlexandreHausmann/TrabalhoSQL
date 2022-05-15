namespace CadastroUsuario.Infrastructure.Interfaces
{
    public interface IRepositoryAsync<T>
    {
        Task Add(T entity);

        Task<List<T>> Get();

        Task<T> GetByGuid(Guid id);
    }
}
