using System.ComponentModel.DataAnnotations;

namespace test4.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LanstName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
