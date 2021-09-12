using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Artist:IEntity
    {
        public int ArtistId { get; set; }
        public string FullName { get; set; }
        public string Photo { get; set; }
        public string History { get; set; }

    }
}
