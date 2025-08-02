using System.ComponentModel.DataAnnotations;

namespace IELTS.EntityModels.Models
{
    public class ReadingPassage
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        public string Content { get; set; } = string.Empty;
        
        [StringLength(50)]
        public string DifficultyLevel { get; set; } = "Intermediate";
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        public virtual ICollection<ReadingQuestion> Questions { get; set; } = new List<ReadingQuestion>();
    }
}