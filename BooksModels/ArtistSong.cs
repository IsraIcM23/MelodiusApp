using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class ArtistSong
    {
        public int id { get; set; }
        public int ArtistID { get; set; }
        public int SongID { get; set; }
        public Artist Artist { get; set; }
        public Song Song { get; set; }  
    }
}
