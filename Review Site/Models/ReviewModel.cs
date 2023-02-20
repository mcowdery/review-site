using System.ComponentModel.DataAnnotations;

namespace Review_Site.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string ReviwerName { get; set; }
        public string Content { get; set; }
    }
}
