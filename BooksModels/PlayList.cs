using BooksModels;
using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class PlayList : BaseEntity
    {
        public string Title { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string? Description { get; set; }
        public bool IsPrivate { get; set; }
        public int? TotalLength { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<PlayListSong> playListSongs { get; set; }
    }
}
