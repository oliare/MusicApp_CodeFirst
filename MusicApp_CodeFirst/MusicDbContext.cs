using Microsoft.EntityFrameworkCore;
using MusicApp_CodeFirst.Entities;

namespace MusicApp_CodeFirst
{
    internal partial class MusicDbContext : DbContext
    {
        public MusicDbContext()
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Album> Albumls { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                        Initial Catalog=MusicAppDB;
                                        Integrated Security=True;
                                        Connect Timeout=2;
                                        Encrypt=False;
                                        Trust Server Certificate=False;
                                        Application Intent=ReadWrite;
                                        Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Album>().HasData(new Album[]
           {
               new Album {Id = 1, Name = "Teenage Dream", ArtistId = 1, Year = 2010, Genre = "Pop"},
               new Album {Id = 2, Name = "Chromatica", ArtistId = 2, Year = 2020, Genre = "Pop"},
               new Album {Id = 3, Name = "Purpose", ArtistId = 3, Year = 2015, Genre = "Pop"},
               new Album {Id = 4, Name = "24K Magic", ArtistId = 4, Year = 2016, Genre = "R&B"},
               new Album {Id = 5, Name = "1989", ArtistId = 5, Year = 2014, Genre = "Pop"},
           });

            modelBuilder.Entity<Playlist>().HasData(new Playlist[]
            {
                new Playlist {Id = 1, Name = "Dance Party", Category = "Pop"},
                new Playlist {Id = 2, Name = "Dance Anthems", Category = "Pop"},
                new Playlist {Id = 3, Name = "R&B Jams", Category = "R&B"},
                new Playlist {Id = 4, Name = "Funky Grooves", Category = "R&B"},
                new Playlist {Id = 5, Name = "Country Hits", Category = "Country"},
                new Playlist {Id = 6, Name = "Piano Ballads", Category = "Pop"}
            });

            modelBuilder.Entity<Artist>().HasData(new Artist[]
            {
                new Artist {Id = 1, Name = "Katy", Surname = "Perry", Country = "USA"},
                new Artist {Id = 2, Name = "Lady", Surname = "Gaga", Country = "USA"},
                new Artist {Id = 3, Name = "Justin", Surname = "Bieber", Country = "Canada"},
                new Artist {Id = 4, Name = "Bruno", Surname = "Mars", Country = "USA"},
                new Artist {Id = 5, Name = "Taylor", Surname = "Swift", Country = "USA"},
                new Artist {Id = 6, Name = "Elton", Surname = "John", Country = "UK"},
                new Artist {Id = 7, Name = "Whitney", Surname = "Houston", Country = "USA"},
                new Artist {Id = 8, Name = "Kanye", Surname = "West", Country = "USA"},
                new Artist {Id = 9, Name = "Travis", Surname = "Scott", Country = "USA"},
                new Artist {Id = 10, Name = "Lil", Surname = "Peep", Country = "USA"},
            });


            modelBuilder.Entity<Track>().HasData(new Track[]
            {
               new Track {Id = 1, Name = "Firework", AlbumId = 1, PlaylistId = 1, Duration = new TimeSpan(0, 3, 48)},
               new Track {Id = 2, Name = "California Gurls", AlbumId = 1, PlaylistId = 1, Duration = new TimeSpan(0, 3, 55)},
               new Track {Id = 3, Name = "Poker Face", AlbumId = 2, PlaylistId = 2, Duration = new TimeSpan(0, 3, 57)},
               new Track {Id = 4, Name = "Bad Romance", AlbumId = 2, PlaylistId = 2, Duration = new TimeSpan(0, 4, 54)},
               new Track {Id = 5, Name = "Baby", AlbumId = 3, PlaylistId = 3, Duration = new TimeSpan(0, 3, 36)},
               new Track {Id = 6, Name = "Sorry", AlbumId = 3, PlaylistId = 3, Duration = new TimeSpan(0, 3, 20)},
               new Track {Id = 7, Name = "Uptown Funk", AlbumId = 4, PlaylistId = 4, Duration = new TimeSpan(0, 4, 30)},
               new Track {Id = 8, Name = "Just the Way You Are", AlbumId = 4, PlaylistId = 4, Duration = new TimeSpan(0, 3, 40)},
               new Track {Id = 9, Name = "Shake It Off", AlbumId = 5, PlaylistId = 5, Duration = new TimeSpan(0, 3, 39)},
               new Track {Id = 10, Name = "Love Story", AlbumId = 5, PlaylistId = 5, Duration = new TimeSpan(0, 3, 55)}
            });


        }     
    }
}
