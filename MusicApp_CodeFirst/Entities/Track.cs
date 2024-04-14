using System.ComponentModel.DataAnnotations;

namespace MusicApp_CodeFirst.Entities
{
    public class Track
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public int PlaylistId { get; set; }
        public TimeSpan Duration { get; set; }
        public virtual Album Album { get; set; }
        public virtual Playlist Playlist { get; set; }
    }
}
