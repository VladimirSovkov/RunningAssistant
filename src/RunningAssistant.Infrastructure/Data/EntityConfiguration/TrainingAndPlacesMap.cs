using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.TrainingModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    class TrainingAndPlacesMap : IEntityTypeConfiguration<TrainingAndPlace>
    {
        public void Configure(EntityTypeBuilder<TrainingAndPlace> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
