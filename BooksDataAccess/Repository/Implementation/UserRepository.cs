using BooksDataAccess.Persistence;
using BooksModels;
using MelodiusDataAccess.Repository.Base;
using MelodiusDataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataAccess.Repository.Implementation
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        public UserRepository(MelodiusContext context) : base(context)
        {
        }

    }
}
