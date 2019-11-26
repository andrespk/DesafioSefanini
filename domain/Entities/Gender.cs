using System.ComponentModel.DataAnnotations;

namespace domain.Entities
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(10)]
        public string Name { get; set; }
    }
}