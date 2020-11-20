using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RunningAssistant.Infrastructure.Data;

namespace RunningAssistant.Infrastructure.Migrations
{
    public class DesignTimeRepositoryContextFactory : IDesignTimeDbContextFactory<RunningAssistantContext>
    {
        public RunningAssistantContext CreateDbContext(string[] args)
        {
            IConfiguration config = MigrationExtension.GetConfig();
            var connectionString = config.GetConnectionString("RunningAssistantConnection");
            var optionsBuilder = new DbContextOptionsBuilder<RunningAssistantContext>();
            optionsBuilder.UseSqlServer(connectionString,
                x => x.MigrationsAssembly("RunningAssistant.Infrastructure.Migrations"));
            return new RunningAssistantContext(optionsBuilder.Options);
        }
    }
}
