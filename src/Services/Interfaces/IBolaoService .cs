using bolao10.api.DataBase.Entities;
using bolao10.api.Dto.Response;

namespace bolao10.api.Services.Interfaces
{
   
        public interface IBolaoService
        {
            Task<Bolao> GetAtivoAsync();
            
        }
    
}
