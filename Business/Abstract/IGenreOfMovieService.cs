using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenreOfMovieService
    {
        IDataResult<List<GenreOfMovie>> GetByMovieId(int movieId);
        IDataResult<List<GenreOfMovie>> GetByTypeId(int typeId);
        IResult Add(GenreOfMovie genreOfMovie);

    }
}
