using bolao10.api.DataBase.Entities;
using bolao10.api.Dto.Request;
using bolao10.api.Dto.Response;
using bolao10.api.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bolao10.api.Controllers
{
    
    [Authorize]
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController: ControllerBase
    {

        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        [Route("GetByEmail")]
        public async Task<ActionResult<Usuario>> GetByEmail(string email)
        {
            try
            {
                var retorno = await _usuarioService.GetByEmailAsync(email);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("Cidades")]
        public async Task<ActionResult<IList<Cidade>>> Cidades()
        {
            try
            {
                var retorno = await _usuarioService.GetCidades();

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
