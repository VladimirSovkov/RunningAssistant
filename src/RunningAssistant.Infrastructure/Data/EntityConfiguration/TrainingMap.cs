using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.TrainingModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    public class TrainingMap : IEntityTypeConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.ToTable("training");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseHiLo(HiLoSequence.DBSequenceHiLoForRunningAssistant);

            builder.Property(x => x.Name).HasMaxLength(20);
            builder.Property(x => x.Type).HasMaxLength(25);
            builder.Property(x => x.Description).HasMaxLength(255);
            //возможно будет ошибка из за duration: DateTime
        }
    }
}
