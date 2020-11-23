using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.TrainingModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    class TrainingAndPlacesMap : IEntityTypeConfiguration<TrainingAndPlace>
    {
        public void Configure(EntityTypeBuilder<TrainingAndPlace> builder)
        {
            builder.ToTable("training_and_place");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseHiLo(HiLoSequence.DBSequenceHiLoForRunningAssistant);

            builder.HasOne(x => x.Place).WithMany().HasForeignKey(x => x.PlaceId);
            builder.HasOne(x => x.Training).WithMany().HasForeignKey(x => x.TrainingId);
        }
    }
}
