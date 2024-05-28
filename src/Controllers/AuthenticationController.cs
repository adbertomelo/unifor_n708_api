using bolao10.api.Dto.Request;
using bolao10.api.Dto.Response;
using bolao10.api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

    }
}
