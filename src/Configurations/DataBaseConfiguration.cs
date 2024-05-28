using bolao10.api.DataBase;
using Microsoft.EntityFrameworkCore;

namespace bolao10.api.Configurations
{
    public static class DataBaseConfiguration
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var connAcesso = configuration.GetConnectionString("Bolao10");

            services.AddDbContext<AuthenticateDbContext>(options =>
                options.UseSqlServer(connAcesso)
            );


        }
    }
}
