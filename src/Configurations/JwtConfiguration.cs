using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace bolao10.api.Configurations
{
    public static class JwtConfiguration
    {
        public static string Secret = "3a4643dcb311dd1edd9184cb48571dcf";
        public static int ExpiresMinutes = 120;

        public static void AddJwtConfiguration(this IServiceCollection services)
        {
            var key = Encoding.ASCII.GetBytes(Secret);
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true
            };

            services.AddSingleton(tokenValidationParameters);

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(jwt =>
            {
                jwt.RequireHttpsMetadata = false;
                jwt.SaveToken = true;
                jwt.TokenValidationParameters = tokenValidationParameters;
            });
        }

        public static void UseJwtConfiguration(this IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}
