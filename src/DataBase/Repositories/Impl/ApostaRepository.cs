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

        public Task<List<Aposta>> GetByParticipante(int participanteId)
        {
            return _acessoDbContext
                        .Apostas
                        .Include(a => a.Jogo)
                        .Include(a => a.Jogo.Rodada)
                        .Include(a => a.Jogo.Rodada.Fase)
                        .Include(a => a.Jogo.Time1)
                        .Include(a => a.Jogo.Time2)
                        .Where(a => a.Participante.Id == participanteId)
                        .OrderBy(a => a.Jogo.Rodada.Fase.Id)
                        .OrderBy( a=> a.Jogo.Rodada.Id)
                        .ToListAsync();
        }
    }

   
}
