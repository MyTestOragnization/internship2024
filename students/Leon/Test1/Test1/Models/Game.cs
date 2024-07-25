using System.ComponentModel.DataAnnotations;

namespace Test1.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Genre { get; set; }

        public string Release { get; set; }

        public string Price { get; set; }
    }
}