using System.ComponentModel.DataAnnotations;

namespace IELTS.EntityModels.Models
{
    public class ReadingPassage
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        
        [Required]
        public string Content { get; set; }
        
        [Required]
        [StringLength(50)]
        public string DifficultyLevel { get; set; } // Academic, General Training
        
        [Required]
        [StringLength(50)]
        public string Section { get; set; } // Section 1, 2, or 3
        
        public int TimeLimit { get; set; } // in minutes
        
        [StringLength(500)]
        public string? Description { get; set; }
        
        public virtual ICollection<ReadingQuestion> Questions { get; set; } = new List<ReadingQuestion>();
        
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}