using System.ComponentModel.DataAnnotations;

namespace domain.Entities
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(10)]
        public string Name { get; set; }

        public bool IsAdmin { get; set; }

        public UserRole(string name)
        {
            Name = name;
        }
    }
}