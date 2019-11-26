using System.ComponentModel.DataAnnotations;

namespace domain.Entities
{
    public class UserSys
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        [Required, StringLength(40)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, StringLength(20)]
        public string Login
        {
            get { return Login; }
            set { UserName = value; }
        }

        [Required]
        public int UserRoleId { get; set; }
    }
}