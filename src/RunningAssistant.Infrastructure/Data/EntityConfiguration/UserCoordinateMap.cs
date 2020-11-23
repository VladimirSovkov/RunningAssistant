using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.UserCoordinateModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    class UserCoordinateMap : IEntityTypeConfiguration<UserCoordinate>
    {
        public void Configure(EntityTypeBuilder<UserCoordinate> builder)
        {
            builder.ToTable("user_coordinate");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseHiLo(HiLoSequence.DBSequenceHiLoForRunningAssistant);
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.IdUser);
        }
    }
}
