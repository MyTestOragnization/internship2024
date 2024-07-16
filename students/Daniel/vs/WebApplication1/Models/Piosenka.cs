using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Piosenka
    {
        [Key]
        public int SongID { get; set; }
        [Required]
        public string SongTitle { get; set; }
        [Required]
        public int SongDuration { get; set; }
        [Required]
        public string SongLyrics { get; set; }
        public string SongGenre { get; set; }

        public Piosenka(int ID,string Title,int Duration,string Lyrics,string Genre)
        {
            SongID = ID;
            SongTitle = Title;
            SongDuration = Duration;
            SongLyrics = Lyrics;
            SongGenre = Genre;
        }
        public Piosenka() { }
    }
    
}
