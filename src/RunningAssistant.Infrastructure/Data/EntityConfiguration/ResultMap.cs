using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.UserModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    class ResultMap : IEntityTypeConfiguration<Result>
    {
        public void Configure(EntityTypeBuilder<Result> builder)
        {
            builder.ToTable("result");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseHiLo(HiLoSequence.DBSequenceHiLoForRunningAssistant);

            builder.HasOne(x => x.Training).WithMany(x => x.Results).HasForeignKey(x => x.TrainingId);

            builder.HasOne(x => x.User).WithMany(x => x.Results).HasForeignKey(x => x.UserId);
        }
    }
}
