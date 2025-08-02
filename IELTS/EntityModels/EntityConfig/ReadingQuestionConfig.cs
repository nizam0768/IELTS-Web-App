using IELTS.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IELTS.Entity_Models.Entity_Config
{
    public class ReadingQuestionConfig : IEntityTypeConfiguration<ReadingQuestion>
    {
        public void Configure(EntityTypeBuilder<ReadingQuestion> builder)
        {
            builder.ToTable("ReadingQuestions").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnType("int").ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.ReadingPassageId).HasColumnType("int").IsRequired();
            builder.Property(x => x.QuestionText).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.QuestionType).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.QuestionNumber).HasColumnType("int").IsRequired();
            builder.Property(x => x.Options).HasColumnType("nvarchar(max)");
            builder.Property(x => x.CorrectAnswer).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(x => x.Explanation).HasColumnType("nvarchar(1000)");
            builder.Property(x => x.Points).HasColumnType("int").IsRequired();
            builder.Property(x => x.CreatedBy).HasColumnType("nvarchar(50)");
            builder.Property(x => x.UpdatedBy).HasColumnType("nvarchar(50)");
            builder.Property(x => x.DeletedBy).HasColumnType("nvarchar(50)");
            builder.Property(x => x.CreatedOn).HasColumnType("datetime");
            builder.Property(x => x.UpdatedOn).HasColumnType("datetime");
            builder.Property(x => x.DeletedOn).HasColumnType("datetime");

            // Relationships
            builder.HasMany(x => x.UserAnswers)
                   .WithOne(x => x.ReadingQuestion)
                   .HasForeignKey(x => x.ReadingQuestionId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Indexes
            builder.HasIndex(x => new { x.ReadingPassageId, x.QuestionNumber })
                   .IsUnique();
        }
    }
}