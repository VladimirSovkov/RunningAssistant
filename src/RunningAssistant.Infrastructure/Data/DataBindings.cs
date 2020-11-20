using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace RunningAssistant.Infrastructure.Data
{
    public static class DataBindings
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddDatabase<T>(this IServiceCollection services, string connectionString)
            where T : DbContext
        {
            return services.AddDbContext<T>(c =>
            {
                try
                {
                    c.UseLazyLoadingProxies().UseSqlServer(connectionString);
                }
                catch (Exception)
                {
                    //TODO: logger
                }
            });
        }
    }
}
