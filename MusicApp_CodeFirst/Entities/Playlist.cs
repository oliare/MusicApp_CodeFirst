using System.ComponentModel.DataAnnotations;

namespace MusicApp_CodeFirst.Entities
{
    public class Playlist
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }

}
