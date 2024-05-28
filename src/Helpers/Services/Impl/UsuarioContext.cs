using System.Security.Claims;

namespace bolao10.api.Helpers.Services.Impl
{
    public class UsuarioContext : IUsuarioContextService
    {
        public UsuarioContext(IHttpContextAccessor httpContextAccessor)
        {
            var claims = httpContextAccessor.HttpContext.User.Claims.ToList();

            if (claims.Any())
            {
                var perfis = claims
                    .Where(w => w.Type == ClaimTypes.Role && w.Value.StartsWith("PEID"))
                    .Select(s => int.Parse(s.Value.Replace("PEID", ""))).ToList();

                var id = int.Parse(claims.Single(s => s.Type == "codigo").Value);
                var login = claims.Single(s => s.Type == "login").Value;
                var nome = claims.Single(s => s.Type == ClaimTypes.Name).Value;
                var email = claims.Single(s => s.Type == ClaimTypes.Email).Value;

                Id = id;
                Login = login;
                Nome = nome;
                Email = email;
            }
        }

        public int Id { get; private set; }

        public string Login { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }


    }

}
