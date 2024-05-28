using bolao10.api.DataBase.Entities;
using bolao10.api.DataBase.Repositories.Impl;
using bolao10.api.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace bolao10.api.Controllers
{

    [Authorize]
    [ApiController]
    public class ApostaController : ControllerBase
    {

        IApostaService _apostaService;
        public ApostaController(IApostaService apostaService)
        {
            _apostaService = apostaService;
        }

        public IList<Aposta> GetByParticipante(Participante participante)
        {
            return [];
        }



    }
}
