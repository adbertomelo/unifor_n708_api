using bolao10.api.DataBase.Entities;
using bolao10.api.DataBase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace bolao10.api.DataBase.Repositories.Impl
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AuthenticateDbContext _acessoDbContext;



        public UsuarioRepository(AuthenticateDbContext acessoDbContext)
        {
            _acessoDbContext = acessoDbContext;
        }

        public Task<Usuario?> GetByEmailAsync(string email)
        {
            return _acessoDbContext.Usuarios
                .AsNoTracking()
                .Include(c => c.Cidade)
                .Include(e => e.Cidade.Estado)
                .Include(p => p.Cidade.Estado.Pais)
                .SingleOrDefaultAsync(w => w.Email == email.ToLower());
        }

        public Task<List<Cidade>> GetCidades()
        {
            return _acessoDbContext
                        .Cidades
                            .ToListAsync();
                
        }
    }

}
