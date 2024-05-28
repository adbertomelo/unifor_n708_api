using bolao10.api.DataBase.Entities;

namespace bolao10.api.Services.Interfaces
{
    public interface IApostaService
    {
        Task<List<Aposta>> GetByParticipante(int id);
    }
}