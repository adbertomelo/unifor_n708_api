using bolao10.api.DataBase.Entities;

namespace bolao10.api.DataBase.Repositories.Interfaces
{
    public interface IApostaRepository
    {
        Task<List<Aposta>> GetByParticipante(int id);
    }
}