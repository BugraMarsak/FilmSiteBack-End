using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MovieType : IEntity
    {
        public int MovieTypeId { get; set; }
        public string MovieTypeName { get; set; }

    }
}
