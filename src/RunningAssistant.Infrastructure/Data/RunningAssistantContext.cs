using Microsoft.EntityFrameworkCore;
using RunningAssistant.Domain.FoodModel;
using RunningAssistant.Infrastructure.Data.EntityConfiguration;

namespace RunningAssistant.Infrastructure.Data
{
    public class RunningAssistantContext : DbContext
    {
        public RunningAssistantContext(DbContextOptions<RunningAssistantContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Food { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FoodMap());
        }
    }
}
