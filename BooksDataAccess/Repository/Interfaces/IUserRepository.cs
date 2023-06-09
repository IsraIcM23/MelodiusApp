﻿using BooksModels;
using MelodiusDataAccess.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataAccess.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
