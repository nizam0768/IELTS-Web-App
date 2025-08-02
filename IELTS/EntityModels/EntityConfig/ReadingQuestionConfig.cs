using IELTS.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IELTS.Entity_Models.Entity_Config
{
    public class ReadingQuestionConfig : IEntityTypeConfiguration<ReadingQuestion>
    {
        public void Configure(EntityTypeBuilder<ReadingQuestion> builder)
        {
            builder.ToTable("ReadingQuestions");
            
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.QuestionText)
                .IsRequired()
                .HasColumnType("nvarchar(max)");
                
            builder.Property(x => x.QuestionType)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValue("Multiple Choice");
                
            builder.Property(x => x.OptionA).HasMaxLength(500);
            builder.Property(x => x.OptionB).HasMaxLength(500);
            builder.Property(x => x.OptionC).HasMaxLength(500);
            builder.Property(x => x.OptionD).HasMaxLength(500);
            
            builder.Property(x => x.CorrectAnswer)
                .IsRequired()
                .HasMaxLength(500);
                
            builder.Property(x => x.Explanation)
                .HasColumnType("nvarchar(max)");
                
            builder.HasOne(x => x.ReadingPassage)
                .WithMany(x => x.Questions)
                .HasForeignKey(x => x.PassageId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(x => x.UserResponses)
                .WithOne(x => x.ReadingQuestion)
                .HasForeignKey(x => x.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}