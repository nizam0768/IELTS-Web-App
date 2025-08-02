using IELTS.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IELTS.Entity_Models.Entity_Config
{
    public class ReadingPassageConfig : IEntityTypeConfiguration<ReadingPassage>
    {
        public void Configure(EntityTypeBuilder<ReadingPassage> builder)
        {
            builder.ToTable("ReadingPassages").HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnType("int").ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Title).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.Content).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.DifficultyLevel).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Section).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.TimeLimit).HasColumnType("int").IsRequired();
            builder.Property(x => x.Description).HasColumnType("nvarchar(500)");
            builder.Property(x => x.CreatedBy).HasColumnType("nvarchar(50)");
            builder.Property(x => x.UpdatedBy).HasColumnType("nvarchar(50)");
            builder.Property(x => x.DeletedBy).HasColumnType("nvarchar(50)");
            builder.Property(x => x.CreatedOn).HasColumnType("datetime");
            builder.Property(x => x.UpdatedOn).HasColumnType("datetime");
            builder.Property(x => x.DeletedOn).HasColumnType("datetime");

            // Relationships
            builder.HasMany(x => x.Questions)
                   .WithOne(x => x.ReadingPassage)
                   .HasForeignKey(x => x.ReadingPassageId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}