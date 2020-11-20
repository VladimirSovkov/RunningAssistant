using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.UserModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    class UserFoodMap : IEntityTypeConfiguration<UserFood>
    {
        public void Configure(EntityTypeBuilder<UserFood> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
