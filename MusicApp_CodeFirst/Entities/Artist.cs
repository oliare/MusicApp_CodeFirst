using System.ComponentModel.DataAnnotations;

namespace MusicApp_CodeFirst.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required, MaxLength(100)]
        public string Country { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}
