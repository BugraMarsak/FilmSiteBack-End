﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GenreOfMovie:IEntity
    {
        public int GenreofMovieId { get; set; }
        public int MovieId { get; set; }
        public int MovieTypeId { get; set; }
    }
}
