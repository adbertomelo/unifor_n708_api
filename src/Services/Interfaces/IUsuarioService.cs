using bolao10.api.DataBase.Entities;

namespace bolao10.api.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> GetByEmailAsync(string email);
        Task<List<Cidade>> GetCidades();

    }
}