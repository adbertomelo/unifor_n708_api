using bolao10.api.DataBase.Entities;
using bolao10.api.DataBase.Repositories.Interfaces;
using bolao10.api.Services.Interfaces;

namespace bolao10.api.Services.Impl
{
    public class BolaoService : IBolaoService
    {

        private readonly IBolaoRepository _bolaoRepository;

        public BolaoService(
            IBolaoRepository bolaoRepository
        )
        {
            _bolaoRepository = bolaoRepository;
        }

        public async Task<Bolao> GetAtivoAsync()
        {
            var bolao = await _bolaoRepository.LocalizarAtivoAsync();

            if (bolao == null)
                throw new Exception("Não há nenhum bolão ativo");

            return bolao;

        }





    }
}
