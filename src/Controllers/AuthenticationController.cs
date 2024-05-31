using bolao10.api.Configurations;
using bolao10.api.Dto.Request;
using bolao10.api.Dto.Response;
using bolao10.api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace bolao10.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController: ControllerBase
    {

        private readonly IAuthenticationService _autenticacaoService;

        public AuthenticationController(IAuthenticationService autenticacaoService)
        {
            _autenticacaoService = autenticacaoService;
        }

        [HttpPost]
        [Route("Entrar")]
        public async Task<ActionResult<AuthenticationResponse>> Entrar([FromBody] AuthenticationRequest request)
        {
            try
            {
                var retorno = await _autenticacaoService.AutenticarGerarTokenAsync(request.Login, request.Senha);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet]
        [Route("TokenValido")]
        public ActionResult<bool> TokenValido(string token)
        {
            try
            {
                var key = Encoding.ASCII.GetBytes(JwtConfiguration.Secret);

                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true
                };

                var tokenHandler = new JwtSecurityTokenHandler();

                _ = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken validatedToken);

                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }

        }

    }
}
