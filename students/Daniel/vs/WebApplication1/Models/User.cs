using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
        [Column("UserName")]
        [Key]
        public string username { get; set; }
        [Column("UserPassword")]
        [Required]
        public string password { get; set; }
        [Column("UserProfilePicture")]
        public string profilePicture { get; set; } = "none";
        [Column("UserLikes")]
        public int likes { get; set; }
        [Column("UserEmail")]
        [Required]
        public string email { get; set; }
        [Column("UserRole")]
        public char role { get; set; } = 'U';
    }
}
