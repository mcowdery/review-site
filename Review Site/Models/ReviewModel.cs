using System.ComponentModel.DataAnnotations;

namespace Review_Site.Models
{
    public class DestinationModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string ReviewerName { get; set; }
        public string Content { get; set; }
    }
}
