using IELTS.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IELTS.Entity_Models.Entity_Config
{
    public class ReadingPassageConfig : IEntityTypeConfiguration<ReadingPassage>
    {
        public void Configure(EntityTypeBuilder<ReadingPassage> builder)
        {
            builder.ToTable("ReadingPassages");
            
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);
                
            builder.Property(x => x.Content)
                .IsRequired()
                .HasColumnType("nvarchar(max)");
                
            builder.Property(x => x.DifficultyLevel)
                .HasMaxLength(50)
                .HasDefaultValue("Intermediate");
                
            builder.Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");
                
            builder.HasMany(x => x.Questions)
                .WithOne(x => x.ReadingPassage)
                .HasForeignKey(x => x.PassageId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}