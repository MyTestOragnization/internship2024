using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RelGTD
    {
        [Key]
        public int Id { get; set; }
        public int IdGame { get; set; }
        public int IdCompany { get; set; }

    }
}