using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IELTS.EntityModels.Models
{
    public class UserResponse
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string SessionId { get; set; } = string.Empty;
        
        [ForeignKey("ReadingQuestion")]
        public int QuestionId { get; set; }
        
        public string UserAnswer { get; set; } = string.Empty;
        
        public bool IsCorrect { get; set; }
        
        public DateTime AnsweredAt { get; set; } = DateTime.Now;
        
        public virtual ReadingQuestion ReadingQuestion { get; set; } = null!;
    }
}