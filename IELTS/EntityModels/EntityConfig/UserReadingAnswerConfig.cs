using IELTS.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IELTS.Entity_Models.Entity_Config
{
    public class UserReadingAnswerConfig : IEntityTypeConfiguration<UserReadingAnswer>
    {
        public void Configure(EntityTypeBuilder<UserReadingAnswer> builder)
        {
            builder.ToTable("UserReadingAnswers").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnType("int").ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.ReadingQuestionId).HasColumnType("int").IsRequired();
            builder.Property(x => x.UserId).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.UserAnswer).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(x => x.IsCorrect).HasColumnType("bit").IsRequired();
            builder.Property(x => x.PointsEarned).HasColumnType("int").IsRequired();
            builder.Property(x => x.AnsweredOn).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.TimeSpent).HasColumnType("time").IsRequired();

            // Indexes
            builder.HasIndex(x => new { x.UserId, x.ReadingQuestionId })
                   .IsUnique();
            builder.HasIndex(x => x.AnsweredOn);
        }
    }
}