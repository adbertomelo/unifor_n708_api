using bolao10.api.DataBase.Entities;

namespace bolao10.api.Services.Interfaces
{
    internal interface IFaseRepository
    {
        Task<List<Fase>> GetAll();
    }
}