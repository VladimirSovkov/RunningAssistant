using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningAssistant.Domain.UserModel;

namespace RunningAssistant.Infrastructure.Data.EntityConfiguration
{
    class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseHiLo(HiLoSequence.DBSequenceHiLoForRunningAssistant);
            builder.Property(x => x.Login).HasMaxLength(30);
            builder.Property(x => x.Password).HasMaxLength(30);
            builder.Property(x => x.Surname).HasMaxLength(40);
            builder.Property(x => x.Name).HasMaxLength(30);
            builder.Property(x => x.Patronymic).HasMaxLength(40);
            //возможно будет ошиба из за гендера
        }
    }
}
