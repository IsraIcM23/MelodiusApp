using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; }
        public string Biography { get; set; }
        public ICollection<ArtistSong> ArtistSongs { get; set; }
    }
}
