using IELTS.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IELTS.Entity_Models.Entity_Config
{
    public class UserResponseConfig : IEntityTypeConfiguration<UserResponse>
    {
        public void Configure(EntityTypeBuilder<UserResponse> builder)
        {
            builder.ToTable("UserResponses");
            
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.SessionId)
                .IsRequired()
                .HasMaxLength(100);
                
            builder.Property(x => x.UserAnswer)
                .HasMaxLength(500);
                
            builder.Property(x => x.AnsweredAt)
                .HasDefaultValueSql("GETDATE()");
                
            builder.HasOne(x => x.ReadingQuestion)
                .WithMany(x => x.UserResponses)
                .HasForeignKey(x => x.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasIndex(x => new { x.SessionId, x.QuestionId })
                .IsUnique();
        }
    }
}