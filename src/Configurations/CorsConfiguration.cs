namespace bolao10.api.Configurations
{

        public static class CorsConfiguration
        {
            public static void AddCorsConfiguration(this IServiceCollection services)
            {
                services.AddCors(options =>
                {
                    options.AddDefaultPolicy(policy =>
                    {
                        policy.WithOrigins("http://localhost:3000")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
                });
            }
        }
    
}
