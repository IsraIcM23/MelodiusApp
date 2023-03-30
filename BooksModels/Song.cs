using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class Song : BaseEntity
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
        public ICollection<PlayListSong>? playListSongs { get; set; }
        public ICollection<AlbumSong>? albumSongs { get; set; }
        public ICollection<ArtistSong>? ArtistSongs { get; set; }


    }
}
