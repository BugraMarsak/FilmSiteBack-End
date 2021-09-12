using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MovieAndArtist : IEntity
    {
        public int MovieAndArtistId { get; set; }
        public int MovieId { get; set; }
        public int ArtistId { get; set; }
        


    }
}
