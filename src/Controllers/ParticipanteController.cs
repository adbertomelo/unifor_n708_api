using bolao10.api.DataBase.Entities;
using bolao10.api.Dto.Request;
using bolao10.api.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bolao10.api.Controllers
{
    [ApiController]
    [Route("Participante")]
    [Authorize]
    public class ParticipanteController: ControllerBase
    {

        private readonly IParticipanteService _participanteService;

        public ParticipanteController(IParticipanteService participanteService)
        {
            _participanteService = participanteService;
        }

        [HttpGet]
        [Route("GetByUsuarioBolao")]
        public async Task<ActionResult<Participante>> GetByUsuarioBolao(int idUsuario, int idBolao)
        {
            try
            {
                var retorno = await _participanteService.GetByUsuarioBolao(idUsuario, idBolao);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetByCodigo")]
        public async Task<ActionResult<Participante>> GetByCodigo(string codigo)
        {
            try
            {
                var retorno = await _participanteService.GetByCodigo(codigo);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("AtualizarInformacoesAcesso")]
        public IActionResult AtualizarInformacoesAcesso([FromBody]ParticipanteRequest participanteRequest)
        {
            try
            {
                _participanteService.AtualizarInformacoesAcesso(participanteRequest.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
