using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }

        [ForeignKey("RegionId")]
        public virtual Region Region { get; set; }

        [Required]
        public int RegionId { get; set; }
    }
}