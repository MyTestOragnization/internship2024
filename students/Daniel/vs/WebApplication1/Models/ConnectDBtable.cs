using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("ConnectDB")]
    public class ConnectDBtable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConnID { get; set; }
        [Required]
        [ForeignKey("FK_IDalbumToAlbum")]
        public int IDalbum { get; set; }

        public Albums albums { get; set; } = null!;

        [Required]
        [ForeignKey("FK_IDartistToArtist")]
        public int IDartist { get; set; }

        public Artist artist { get; set; } = null!;
        [Required]
        [ForeignKey("FK_IDsongToSongs")]
        public int IDsong { get; set; }
        public Song song { get; set; } = null!;

        public string? AlbumTitle { get; set; }
        public string? AlbumID { get; set; }
        public string? SongTitle { get; set; }
        public string? SongID { get; set; }
        public string? ArtistName { get; set; }
        public string? ArtistID { get; set; }

    }
}
//AlbumTitle, AlbumID, SongTitle, SongID, ArtistName, ArtistID