using bolao10.api.Configurations;
using bolao10.api.DataBase.Entities;
using bolao10.api.Dto.Response;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using bolao10.api.Helpers.Services;
using bolao10.api.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using bolao10.api.DataBase.Repositories.Interfaces;

namespace bolao10.api.Services.Impl
{
    public class AuthenticationService : IAuthenticationService
    {

        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IUsuarioContextService _usuarioContext;
        private readonly IEncryptionService _encryptionService;

        public AuthenticationService(
            IUsuarioRepository usuarioRepository,
            IMapper mapper,
            IUsuarioContextService usuarioContext,
            IEncryptionService encryptionService
        )
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _usuarioContext = usuarioContext;
            _encryptionService = encryptionService;
        }

        public async Task<AuthenticationResponse> AutenticarGerarTokenAsync(string login, string senha)
        {
            var usuario = await _usuarioRepository.GetByEmailAsync(login);

            if (usuario == null)
                throw new Exception("Usuário não localizado");

            string senhaEncript = _encryptionService.Encrypt(senha);

            if (!senhaEncript.Equals(usuario.Senha))
            {
                throw new Exception("Usuário ou senha inválidos");
            }

            var token = GerarToken(usuario);

            var retorno = _mapper.Map<AuthenticationResponse>(usuario);

            retorno.Token = token;

            return retorno;


        }

        private string GerarToken(Usuario usuario)
        {
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, usuario.Nome),
                new(ClaimTypes.Email, usuario.Email),
            };

            var key = Encoding.ASCII.GetBytes(JwtConfiguration.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(JwtConfiguration.ExpiresMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var createToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(createToken);

            return token;
        }



    }
}
