using System.ComponentModel.DataAnnotations;

namespace Test1.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Country { get; set; }

        public string CEO { get; set; }

        public string Estabilished { get; set; }
    }
}