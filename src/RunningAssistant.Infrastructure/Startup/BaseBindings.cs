
using Microsoft.Extensions.DependencyInjection;
using RunningAssistant.Infrastructure.Data;

namespace RunningAssistant.Infrastructure.Startup
{
    public static class BaseBindings
    {
        public static IServiceCollection AddBaseServices(this IServiceCollection services)
        {
            return services.AddRepositories();
        }
    }
}
