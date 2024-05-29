using bolao10.api.DataBase.Entities;
using bolao10.api.DataBase.Repositories.Impl;
using bolao10.api.Dto.Request;
using bolao10.api.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace bolao10.api.Controllers
{

    [Authorize]
    [Route("Apostas")]
    [ApiController]
    public class ApostaController : ControllerBase
    {

        IApostaService _apostaService;
        public ApostaController(IApostaService apostaService)
        {
            _apostaService = apostaService;
        }

        [HttpGet]
        [Route("GetByParticipante")]
        public Task<List<Aposta>> GetByParticipante(int idParticipante)
        {
            return _apostaService.GetByParticipante(idParticipante);
        }



    }
}
