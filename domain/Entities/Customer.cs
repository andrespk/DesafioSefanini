using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Phone { get; set; }

        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }

        public int GenderId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }

        public int CityId { get; set; }

        [ForeignKey("RegionId")]
        public Region Region { get; set; }

        public int RegionId { get; set; }

        public DateTime LastPurchase;

        [ForeignKey("ClassificationId")]
        public Classification Classification { get; set; }

        public int ClassificationId { get; set; }

        [ForeignKey("UserId")]
        public UserSys User { get; set; }

        public int UserId { get; set; }
    }
}