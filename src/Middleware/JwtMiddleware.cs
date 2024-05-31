using bolao10.api.DataBase;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace bolao10.api.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(
            HttpContext context,
            //AuthenticateDbContext acessoDbContext,
            TokenValidationParameters tokenValidationParameters
        )
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                try
                {

                    var tokenHandler = new JwtSecurityTokenHandler();

                    tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken validatedToken);

                    var jwtToken = (JwtSecurityToken)validatedToken;
             
                }
                catch
                {
                    throw;
                }
            }

            await _next(context);
        }
    }

}
