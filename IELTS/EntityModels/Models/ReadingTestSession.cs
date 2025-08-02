using System.ComponentModel.DataAnnotations;

namespace IELTS.EntityModels.Models
{
    public class ReadingTestSession
    {
        public int Id { get; set; }
        
        public int ReadingPassageId { get; set; }
        public virtual ReadingPassage ReadingPassage { get; set; }
        
        [Required]
        [StringLength(100)]
        public string UserId { get; set; }
        
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        
        public int TotalQuestions { get; set; }
        public int CorrectAnswers { get; set; }
        public int TotalPoints { get; set; }
        public double ScorePercentage { get; set; }
        
        public TimeSpan TotalTimeSpent { get; set; }
        
        public bool IsCompleted { get; set; }
        
        [StringLength(20)]
        public string? IELTSBandScore { get; set; } // e.g., "7.5", "8.0"
    }
}