using bolao10.api.DataBase.Entities;
using bolao10.api.DataBase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace bolao10.api.DataBase.Repositories.Impl
{
    public class BolaoRepository : IBolaoRepository
    {
        private readonly AuthenticateDbContext _acessoDbContext;



        public BolaoRepository(AuthenticateDbContext acessoDbContext)
        {
            _acessoDbContext = acessoDbContext;
        }

        public Task<Bolao?> LocalizarAtivoAsync()
        {
            return _acessoDbContext.Boloes
                .AsNoTracking()
                .SingleOrDefaultAsync(w => w.Situacao == 1);
        }


    }

}
