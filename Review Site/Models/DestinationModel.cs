using System.ComponentModel.DataAnnotations;

namespace Review_Site.Models
{
    public class DestinationModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public string Description { get; set; }
        public List<string> Countries { get; set; }
        public List<string> Cities { get; set; }
        public int TourDuration { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<DestinationModel> Reviews { get; set; } = null!;
    }
}




