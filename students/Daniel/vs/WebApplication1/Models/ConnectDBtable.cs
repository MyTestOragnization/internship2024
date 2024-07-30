using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("ConnectDB")]
    public class ConnectDBtable
    {
        [Column("IDAlbum")]
        [Required]
        [ForeignKey("IDAlbum")]
        public int AlbumId { get; set; }
        [Column("IDartist")]
        [Required]
        [ForeignKey("IDartist")]
        public int ArtistId { get; set; }
        [Column("IDSong")]
        [Required]
        [ForeignKey("IDSong")]
        public int SongId { get; set; }
    }
}
