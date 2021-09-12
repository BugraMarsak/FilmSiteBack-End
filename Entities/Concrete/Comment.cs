using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment: IEntity
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int MovieId { get; set; }
        public string Remark { get; set; }
        public int Rate { get; set; }
    }
}
