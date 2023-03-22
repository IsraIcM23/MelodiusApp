using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class AlbumSong
    {
        public int id { get; set; }
        public int AlbumID { get; set; }
        public int SongID { get; set; }
        public Album Album { get; set; }   
        public Song Song { get; set; }  
    }
}
