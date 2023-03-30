using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class AlbumSong : BaseEntity
    {
        public Song Song { get; set; } = null!;
        public int SongID { get; set; }

        public Album Album { get; set; } = null!;
        public int AlbumID { get; set; }

    }
}
