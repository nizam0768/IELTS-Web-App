using System.ComponentModel.DataAnnotations;

namespace IELTS.EntityModels.Models
{
    public class UserReadingAnswer
    {
        public int Id { get; set; }
        
        public int ReadingQuestionId { get; set; }
        public virtual ReadingQuestion ReadingQuestion { get; set; }
        
        [Required]
        [StringLength(100)]
        public string UserId { get; set; } // Can be email or user identifier
        
        [Required]
        public string UserAnswer { get; set; }
        
        public bool IsCorrect { get; set; }
        
        public int PointsEarned { get; set; }
        
        public DateTime AnsweredOn { get; set; } = DateTime.UtcNow;
        
        public TimeSpan TimeSpent { get; set; }
    }
}