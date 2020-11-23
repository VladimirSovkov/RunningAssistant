using Microsoft.EntityFrameworkCore;
using RunningAssistant.Domain.FoodModel;
using RunningAssistant.Domain.PlaceModel;
using RunningAssistant.Domain.TrainingModel;
using RunningAssistant.Domain.UserCoordinateModel;
using RunningAssistant.Domain.UserModel;
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
        public DbSet<Place> Places { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TrainingAndPlace> TrainingAndPlaces { get; set; }
        public DbSet<UserCoordinate> UserCoordinates { get; set; }
        public DbSet<UserFood> UserFoods { get; set; }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FoodMap());
            builder.ApplyConfiguration(new PlaceMap());
            builder.ApplyConfiguration(new ResultMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new TrainingMap());
            builder.ApplyConfiguration(new TrainingAndPlacesMap());
            builder.ApplyConfiguration(new UserCoordinateMap());
            builder.ApplyConfiguration(new UserFoodMap());
        }
    }
}
