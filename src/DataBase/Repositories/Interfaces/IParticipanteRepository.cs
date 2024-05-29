using bolao10.api.DataBase.Entities;

namespace bolao10.api.DataBase.Repositories.Interfaces
{
    public interface IParticipanteRepository
    {
        Task<Participante?> GetById(int idParticipante);
        Task<Participante?> GetByUsuarioBolao(int idUsuario, int idBolao);

        void Atualizar(Participante participante);
        Task<Participante?> GetByCodigo(string codigo);
        Task<List<Participante>> GetAll();
    }
}