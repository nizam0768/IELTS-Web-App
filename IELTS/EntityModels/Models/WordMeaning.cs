namespace IELTS.EntityModels.Models
{
    public class WordMeaning
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string PartofSpeech { get; set; }
        public string Pronunciation { get; set; }
        public string Definition { get; set; }
        public string Usage { get; set; }
        public string RelatedWords { get; set; }
        public string MoreInfo { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
