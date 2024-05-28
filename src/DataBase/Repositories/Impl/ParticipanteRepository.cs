using bolao10.api.DataBase.Entities;
using bolao10.api.DataBase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace bolao10.api.DataBase.Repositories.Impl
{
    public class ParticipanteRepository(AuthenticateDbContext acessoDbContext) : IParticipanteRepository
    {
        private readonly AuthenticateDbContext _acessoDbContext = acessoDbContext;

        public Task<Participante?> GetById(int idParticipante)
        {
            return _acessoDbContext.Participantes
                .AsNoTracking()
                .SingleOrDefaultAsync(w => w.Id == idParticipante);

        }

        public void Atualizar(Participante participante)
        {
            _acessoDbContext.Set<Participante>().Update(participante);
            
        }

        public Task<Participante?> GetByUsuarioBolao(int idUsuario, int idBolao)
        {
            return _acessoDbContext.Participantes
                .AsNoTracking()
                .Include(c => c.Usuario)
                .Include(e => e.Bolao)
                .SingleOrDefaultAsync(w => w.Bolao.Id == idBolao && w.Usuario.Id == idUsuario);
        }

        public Task<Participante?> GetByCodigo(string codigo)
        {
            return _acessoDbContext.Participantes
                .AsNoTracking()
                .Include(c => c.Usuario)
                .Include(d => d.Usuario.Cidade)
                .Include(e => e.Usuario.Cidade.Estado)
                .Include(f => f.Usuario.Cidade.Estado.Pais)
                .Include(g => g.Bolao)
                .SingleOrDefaultAsync(w => w.Codigo == codigo);
        }

    }

}
