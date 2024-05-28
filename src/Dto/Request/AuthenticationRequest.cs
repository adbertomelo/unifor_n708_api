using System.ComponentModel.DataAnnotations;

namespace bolao10.api.Dto.Request
{
    public class AuthenticationRequest
    {

        [Required(ErrorMessage = "O campo Login é obrigatório")]
        public string Login { get; init; }

        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        public string Senha { get; init; }
        
    }
}
