using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int TourDuration { get; set; }
        public decimal Price { get; set; }
        [NotMapped]
        public List<string> Countries
        {
            get { return Country.Split(',').ToList(); }
        }
        [NotMapped]
        public List<string> Cities
        {
            get { return City.Split(',').ToList(); }
        }
        public virtual ICollection<DestinationModel> Reviews { get; set; } = null!;
    }
}




