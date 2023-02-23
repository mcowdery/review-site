using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Review_Site.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string ReviewerName { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
        public string DateTime { get; set; }
        public int StarRating { get; set; }
        [ForeignKey("DesinationModel")]//telling which modelto use for foreign key
        public int DestinationId { get; set; }
        public virtual DestinationModel Destination { get; set; }

    }
}
