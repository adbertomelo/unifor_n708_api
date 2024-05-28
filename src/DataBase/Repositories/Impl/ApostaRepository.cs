using bolao10.api.DataBase.Entities;
using bolao10.api.DataBase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace bolao10.api.DataBase.Repositories.Impl
{
    public class ApostaRepository : IApostaRepository
    {
        private readonly AuthenticateDbContext _acessoDbContext;



        public ApostaRepository(AuthenticateDbContext acessoDbContext)
        {
            _acessoDbContext = acessoDbContext;
        }



    }

   
}
