using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.UserModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
