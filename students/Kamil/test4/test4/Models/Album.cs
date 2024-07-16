using System.ComponentModel.DataAnnotations;

namespace test4.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string AlbumName { get; set; }

        public string YearReleaseAlbum { get; set; }

        public string MadeIn { get; set; }

        public string Price { get; set; }

        public int Amount { get; set; }
    }
}
