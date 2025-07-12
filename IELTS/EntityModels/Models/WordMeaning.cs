using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace IELTS.EntityModels.Models
{
    public class WordMeaning
    {
        public int Id { get; set; }
        [Required]
        public string Word { get; set; }
        [Required]
        public string PartofSpeech { get; set; }
        [Required]
        public string Pronunciation { get; set; }
        [Required]
        public string Definition { get; set; }
        [Required]
        public string Usage { get; set; }
        [Required]
        public string RelatedWords { get; set; }
        [Required]
        public string MoreInfo { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
