using bolao10.api.Helpers.Services.Impl;
using bolao10.api.Helpers.Services;
using bolao10.api.Services.Interfaces;
using bolao10.api.Services.Impl;

namespace bolao10.api.Configurations
{
    public static class ServicesConfiguration
    {
        public static void AddServicesConfiguration(this IServiceCollection services)
        {

            services.AddScoped<IUsuarioContextService, UsuarioContext>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IEncryptionService, EncryptionService>();
            services.AddScoped<IBolaoService, BolaoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IParticipanteService, ParticipanteService>();
            services.AddScoped<IApostaService, ApostaService>();

        }
    }

}
