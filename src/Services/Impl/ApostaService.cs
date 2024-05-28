using bolao10.api.DataBase.Entities;
using bolao10.api.DataBase.Repositories.Interfaces;
using bolao10.api.Services.Interfaces;

namespace bolao10.api.Services.Impl
{

    public class ApostaService : IApostaService
    {

        IApostaRepository _apostaRepository;
        public ApostaService(IApostaRepository apostaRepository) {
            _apostaRepository = apostaRepository;
        }
        public Task<List<Aposta>> GetByParticipante(int id)
        {
            return _apostaRepository.GetByParticipante(id);
        }
    }
}
