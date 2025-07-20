using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IELTS.EntityModels.Models
{
    public class MyFavoriteWords
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("WordMeaning")]
        public int WordId { get; set; }
        public virtual WordMeaning WordMeaning { get; set; }

    }
}
