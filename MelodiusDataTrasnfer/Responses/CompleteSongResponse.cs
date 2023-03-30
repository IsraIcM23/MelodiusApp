using MelodiusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTrasnfer.Responses
{
    public class CompleteSongResponse
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public ICollection<AlbumSong>? albumSongs { get; set; }

    }
}

