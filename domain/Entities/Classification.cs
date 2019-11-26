using System.ComponentModel.DataAnnotations;

namespace domain.Entities
{
    public class Classification
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }
    }
}