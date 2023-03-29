using BooksDataAccess.Persistence;
using BooksModels;
using MelodiusDataAccess.Repository.Base;
using MelodiusDataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataAccess.Repository.Implementation
{
    public class ArtistRepository : BaseRepository<User>, IUserRepository
    {

        public ArtistRepository(MelodiusContext context) : base(context)
        {
        }

    }
}
