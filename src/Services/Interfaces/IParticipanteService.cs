using bolao10.api.DataBase.Entities;

namespace bolao10.api.Services.Interfaces
{
    public interface IParticipanteService
    {
        
        void AtualizarInformacoesAcesso(int idParticipante);
        Task GetAll();
        Task<Participante> GetByCodigo(string codigo);
        Task<Participante> GetByUsuarioBolao(int idUsuario, int idBolao);
    }
}