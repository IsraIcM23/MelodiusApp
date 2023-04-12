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
    public class ArtistSongRepository : BaseRepository<ArtistSong>, IArtistSongRepository
    {
        public ArtistSongRepository(MelodiusContext context) : base(context)
        {
        }
    }
}