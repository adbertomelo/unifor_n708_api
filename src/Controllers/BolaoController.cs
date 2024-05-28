using bolao10.api.DataBase.Entities;
using bolao10.api.Dto.Request;
using bolao10.api.Dto.Response;
using bolao10.api.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bolao10.api.Controllers
{
    [ApiController]
    [Route("Boloes")]
    [Authorize]
    public class BolaoController: ControllerBase
    {

        private readonly IBolaoService _bolaoService;

        public BolaoController(IBolaoService bolaoService)
        {
            _bolaoService = bolaoService;
        }

        [HttpGet]
        [Route("Ativo")]
        public async Task<ActionResult<Bolao>> Ativo()
        {
            try
            {
                var retorno = await _bolaoService.GetAtivoAsync();

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
