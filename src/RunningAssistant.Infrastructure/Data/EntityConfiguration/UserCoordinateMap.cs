using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.UserCoordinateModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    class UserCoordinateMap : IEntityTypeConfiguration<UserCoordinate>
    {
        public void Configure(EntityTypeBuilder<UserCoordinate> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
