using bolao10.api.Middleware;

namespace bolao10.api.Configurations
{
    public static class MiddlewareConfiguration
    {
        public static void UseMiddlewareConfiguration(this IApplicationBuilder app)
        {
            app.UseMiddleware<JwtMiddleware>();
        }
    }

}
