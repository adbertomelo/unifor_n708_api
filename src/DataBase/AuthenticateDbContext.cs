using bolao10.api.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace bolao10.api.DataBase
{
    public class AuthenticateDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Bolao> Boloes { get; set; }

        public DbSet<Aposta> Apostas { get; set; }

        public DbSet<Participante> Participantes { get; set; }
        public AuthenticateDbContext(DbContextOptions<AuthenticateDbContext> options) : base(options)
        {

        }

 
    }
}
