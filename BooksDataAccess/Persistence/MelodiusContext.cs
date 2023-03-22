using BooksModels;
using MelodiusModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDataAccess.Persistence
{
    public class MelodiusContext: DbContext
    {

        public MelodiusContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        public DbSet<AlbumSong> AlbumSongs { get; set; }
        public DbSet<PlayListSong> PlayListSongs { get; set; }
        public DbSet<ArtistSong> ArtistSongs { get; set; }


    }
}
