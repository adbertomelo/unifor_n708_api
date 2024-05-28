using bolao10.api.DataBase.Repositories.Impl;
using bolao10.api.DataBase.Repositories.Interfaces;

namespace bolao10.api.Configurations
{
    public static class RepositoriesConfiguration
    {
        public static void AddRepositoriesConfiguration(this IServiceCollection services)
        {


            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IBolaoRepository, BolaoRepository>();
            services.AddScoped<IParticipanteRepository, ParticipanteRepository>();
            services.AddScoped<IApostaRepository, ApostaRepository>();


        }
    }
}
