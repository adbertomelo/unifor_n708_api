using bolao10.api.DataBase.Entities;

namespace bolao10.api.DataBase.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        //Task<Usuario> LocalizarAcessoAsync(int idUsuario, int idEmpresa);
        Task<Usuario?> GetByEmailAsync(string email);
        Task<List<Cidade>> GetCidades();
        //Task AtualizarTokenAsync(int idUsuario, string token);
        //Task RemoverTokenAsync(int idUsuario);

    }
}
