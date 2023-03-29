using BooksDataAccess.Persistence;
using MelodiusDataAccess.Repository.Base;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataAccess.Repository.Implementation
{
    public class PlayListSongRepository : BaseRepository<PlayListSong>, IPlayListSongRepository
    {
        public PlayListSongRepository(MelodiusContext context) : base(context)
        {
        }
    }
}
