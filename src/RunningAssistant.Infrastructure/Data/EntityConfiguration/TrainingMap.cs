using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.TrainingModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    public class TrainingMap : IEntityTypeConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
