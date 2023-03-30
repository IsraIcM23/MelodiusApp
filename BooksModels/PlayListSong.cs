using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class PlayListSong : BaseEntity
    {
        //public int Id { get; set; }
        public int  PlaylistID { get; set; }
        public int  SongID { get; set; }
        public PlayList PlayList { get; set; }
        public Song Song { get; set; }
    }
}
