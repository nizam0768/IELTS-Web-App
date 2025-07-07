using IELTS.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IELTS.Entity_Models.Entity_Config
{
    public class WordMeaningConfig : IEntityTypeConfiguration<WordMeaning>
    {
        public void Configure(EntityTypeBuilder<WordMeaning> builder)
        {
            builder.ToTable("WordMeanings").HasKey(x =>x.Id);

            builder.Property(x => x.Id).HasColumnType("int").ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Word).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.PartofSpeech).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Pronunciation).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Definition).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(x => x.Usage).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(x => x.RelatedWords).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(x => x.MoreInfo).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(x => x.CreatedBy).HasColumnType("nvarchar(50)");
            builder.Property(x => x.UpdatedBy).HasColumnType("nvarchar(50)");
            builder.Property(x => x.DeletedBy).HasColumnType("nvarchar(50)");
            builder.Property(x => x.CreatedOn).HasColumnType("datetime");
            builder.Property(x => x.UpdatedOn).HasColumnType("datetime");
            builder.Property(x => x.DeletedOn).HasColumnType("datetime");
        }
    }
}
