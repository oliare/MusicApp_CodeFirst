using System.ComponentModel.DataAnnotations;

namespace MusicApp_CodeFirst.Entities
{
    public class Album
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public int Year { get; set; }
        [Required]
        [MaxLength(100)]
        public string Genre { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
