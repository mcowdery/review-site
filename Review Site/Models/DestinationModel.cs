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
        public string Country { get; set; }
        public string City { get; set; }
        public int YearBuilt { get; set; }
        public int VisitDuration { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<DestinationModel> Reviews { get; set; } = null!;
    }
}
