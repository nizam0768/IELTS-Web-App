using IELTS.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IELTS.Entity_Models.Entity_Config
{
    public class ReadingTestSessionConfig : IEntityTypeConfiguration<ReadingTestSession>
    {
        public void Configure(EntityTypeBuilder<ReadingTestSession> builder)
        {
            builder.ToTable("ReadingTestSessions").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnType("int").ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.ReadingPassageId).HasColumnType("int").IsRequired();
            builder.Property(x => x.UserId).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.StartTime).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.EndTime).HasColumnType("datetime");
            builder.Property(x => x.TotalQuestions).HasColumnType("int").IsRequired();
            builder.Property(x => x.CorrectAnswers).HasColumnType("int").IsRequired();
            builder.Property(x => x.TotalPoints).HasColumnType("int").IsRequired();
            builder.Property(x => x.ScorePercentage).HasColumnType("decimal(5,2)").IsRequired();
            builder.Property(x => x.TotalTimeSpent).HasColumnType("time").IsRequired();
            builder.Property(x => x.IsCompleted).HasColumnType("bit").IsRequired();
            builder.Property(x => x.IELTSBandScore).HasColumnType("nvarchar(20)");

            // Relationships
            builder.HasOne(x => x.ReadingPassage)
                   .WithMany()
                   .HasForeignKey(x => x.ReadingPassageId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Indexes
            builder.HasIndex(x => new { x.UserId, x.StartTime });
            builder.HasIndex(x => x.IsCompleted);
        }
    }
}