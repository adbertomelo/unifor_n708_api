using bolao10.api.DataBase.Entities;
using bolao10.api.Dto.Request;
using bolao10.api.Dto.Response;
using bolao10.api.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bolao10.api.Controllers
{
    [ApiController]
    [Route("Chat")]
    [Authorize]
    public class ChatController: ControllerBase
    {

        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }



    }
}
