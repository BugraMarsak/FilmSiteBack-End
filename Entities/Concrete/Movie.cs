using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Movie :IEntity
    {
        public int MovieId { get; set; }
        public string CoverImage { get; set; }
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public int ReleaseDate { get; set; }
        public string Explanation { get; set; }

    }  
}
