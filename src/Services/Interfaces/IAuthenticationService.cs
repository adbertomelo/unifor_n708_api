using bolao10.api.Dto.Response;

namespace bolao10.api.Services.Interfaces
{
   
        public interface IAuthenticationService
        {
            Task<AuthenticationResponse> AutenticarGerarTokenAsync(string login, string senha);
            
        }
    
}
