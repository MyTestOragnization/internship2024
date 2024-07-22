using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test4.Models
{
    public class AlbumNice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string AlbumName { get; set; }
        public string Name { get; set; }

        public string YearReleaseAlbum { get; set; }

        public string MadeIn { get; set; }

        public string Price { get; set; }

        public int Amount { get; set; }
    }
}
