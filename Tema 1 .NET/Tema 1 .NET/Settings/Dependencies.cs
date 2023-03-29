

using Tema_1_.NET.Repositories;
using Tema_1_.NET.Services.MotorcycleService;

namespace Tema_1_.NET.Settings
{
    public static class Dependencies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<MotorcycleService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<MotorcycleRepository>();
        }
    }
}
