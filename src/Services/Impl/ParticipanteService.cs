using bolao10.api.DataBase.Entities;
using bolao10.api.DataBase.Repositories.Interfaces;
using bolao10.api.Services.Interfaces;

namespace bolao10.api.Services.Impl
{
    public class ParticipanteService : IParticipanteService
    {

        private readonly IParticipanteRepository _participanteRepository;

        public ParticipanteService(IParticipanteRepository participanteRepository)
        {
            _participanteRepository = participanteRepository;
        }

        public void AtualizarInformacoesAcesso(int idParticipante)
        {
            Participante? participante = _participanteRepository.GetById(idParticipante).Result;

            if (participante != null)
            {
                participante.DataHoraAcesso = DateTime.Now;

                participante.NumAcessos++;

                _participanteRepository.Atualizar(participante);
            }

        }

        public async Task<Participante> GetByUsuarioBolao(int idUsuario, int idBolao)
        {
            var res = await _participanteRepository.GetByUsuarioBolao(idUsuario, idBolao);

            if (res == null)
                throw new Exception("Participante não encontrado.");

            return res;

        }


        public async Task<Participante> GetByCodigo(string codigo)
        {
            var res = await _participanteRepository.GetByCodigo(codigo);

            if (res == null)
                throw new Exception("Participante não encontrado.");

            return res;

        }


    }
}
