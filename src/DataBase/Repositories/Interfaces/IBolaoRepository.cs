using bolao10.api.DataBase.Entities;

namespace bolao10.api.DataBase.Repositories.Interfaces
{
    public interface IBolaoRepository
    {
        //Task<Usuario> LocalizarAcessoAsync(int idUsuario, int idEmpresa);
        Task<Bolao?> LocalizarAtivoAsync();
        //Task AtualizarTokenAsync(int idUsuario, string token);
        //Task RemoverTokenAsync(int idUsuario);

    }
}
