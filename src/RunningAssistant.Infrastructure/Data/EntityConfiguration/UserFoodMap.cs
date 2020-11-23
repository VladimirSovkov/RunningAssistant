using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.UserModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    class UserFoodMap : IEntityTypeConfiguration<UserFood>
    {
        public void Configure(EntityTypeBuilder<UserFood> builder)
        {
            builder.ToTable("user_food");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseHiLo(HiLoSequence.DBSequenceHiLoForRunningAssistant);

            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.IdUser);
            builder.HasOne(x => x.Food).WithMany().HasForeignKey(x => x.IdFood);
        }
    }
}
