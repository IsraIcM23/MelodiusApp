﻿using MelodiusModels;
using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksModels
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<PlayList> playLists { get; set; }

    }
}
