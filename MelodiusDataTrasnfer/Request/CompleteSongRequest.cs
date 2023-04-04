using MelodiusDataTrasnfer.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTrasnfer.Request
{
    public class CompleteSongRequest
    {
        public SongDto Song { get; set; }
        public List<int> AlbumIds { get; set; }
        public List<int> PlayListIds { get; set; }
    }
}
