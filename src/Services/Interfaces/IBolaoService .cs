using bolao10.api.DataBase.Entities;
using bolao10.api.Dto.Response;

namespace bolao10.api.Services.Interfaces
{
   
        public interface IBolaoService
        {
            Task<Bolao> GetAtivoAsync();
            Task<List<Fase>> GetFases(int idBolao);
            Task<List<Rodada>> GetRodadas(int idBolao);
        }
    
}
