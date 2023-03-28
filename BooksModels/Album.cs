using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class Album : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<AlbumSong> albumSongs { get; set; }
    }
}
