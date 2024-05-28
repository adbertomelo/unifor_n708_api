
using bolao10.api.Configurations;
using Microsoft.Extensions.FileProviders;

namespace bolao10.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCorsConfiguration();

            services.AddControllers();

            services.AddHttpContextAccessor();

            services.AddJwtConfiguration();

            services.AddAutoMapper(typeof(AutoMapperConfiguration));

            services.AddRepositoriesConfiguration();

            services.AddServicesConfiguration();

            services.AddDatabaseConfiguration(Configuration);

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var isDevelopment = env.IsDevelopment();
            if (isDevelopment)
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors();

            app.UseMiddlewareConfiguration();

            app.UseRouting();

            app.UseJwtConfiguration();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
