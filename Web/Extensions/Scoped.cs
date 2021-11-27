using Core.Interfaces;
using Infrastructure.Services;

namespace Web.Extensions
{
    public class Scoped
    {
        public static void AddScopedConfig(ref IServiceCollection services)
        {
            // add services and their interfaces here
            services.AddScoped<IRandomService, RandomService>();
        }
    }
}
