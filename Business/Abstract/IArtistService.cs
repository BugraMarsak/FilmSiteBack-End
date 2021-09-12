using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IArtistService
    {
        IDataResult<List<Artist>> GetAll();
        IDataResult<Artist> GetById(int artistId);
        IResult Add(Artist artist);
    }
}
