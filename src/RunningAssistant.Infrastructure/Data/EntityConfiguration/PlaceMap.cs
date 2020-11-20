using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.PlaceModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    public class PlaceMap : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseHiLo(HiLoSequence.DBSequenceHiLoForRunningAssistant);

            builder.Property(x => x.Street).HasMaxLength(50);
            builder.Property(x => x.City).HasMaxLength(30);
        }
    }
}
