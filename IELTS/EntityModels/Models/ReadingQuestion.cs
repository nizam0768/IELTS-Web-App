using System.ComponentModel.DataAnnotations;

namespace IELTS.EntityModels.Models
{
    public class ReadingQuestion
    {
        public int Id { get; set; }
        
        public int ReadingPassageId { get; set; }
        public virtual ReadingPassage ReadingPassage { get; set; }
        
        [Required]
        public string QuestionText { get; set; }
        
        [Required]
        [StringLength(50)]
        public string QuestionType { get; set; } // MultipleChoice, TrueFalse, Matching, FillInTheBlank, ShortAnswer
        
        public int QuestionNumber { get; set; }
        
        public string? Options { get; set; } // JSON string for multiple choice options
        
        [Required]
        public string CorrectAnswer { get; set; }
        
        public string? Explanation { get; set; }
        
        public int Points { get; set; } = 1;
        
        public virtual ICollection<UserReadingAnswer> UserAnswers { get; set; } = new List<UserReadingAnswer>();
        
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}