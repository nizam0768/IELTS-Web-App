using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IELTS.EntityModels.Models
{
    public class ReadingQuestion
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string QuestionText { get; set; } = string.Empty;
        
        [Required]
        public string QuestionType { get; set; } = "Multiple Choice"; // Multiple Choice, True/False, Fill in the blank
        
        public string OptionA { get; set; } = string.Empty;
        public string OptionB { get; set; } = string.Empty;
        public string OptionC { get; set; } = string.Empty;
        public string OptionD { get; set; } = string.Empty;
        
        [Required]
        public string CorrectAnswer { get; set; } = string.Empty;
        
        public string Explanation { get; set; } = string.Empty;
        
        public int OrderNumber { get; set; }
        
        [ForeignKey("ReadingPassage")]
        public int PassageId { get; set; }
        
        public virtual ReadingPassage ReadingPassage { get; set; } = null!;
        
        public virtual ICollection<UserResponse> UserResponses { get; set; } = new List<UserResponse>();
    }
}