using Business.Abstract;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GenreOfMovieManager : IGenreOfMovieService
    {
        IGenreOfMovieDal _genreOfMovie;

        public GenreOfMovieManager(IGenreOfMovieDal genreOfMovie)
        {
            _genreOfMovie = genreOfMovie;
        }

        public IResult Add(GenreOfMovie genreOfMovie)
        {
            _genreOfMovie.Add(genreOfMovie);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<GenreOfMovie>> GetByMovieId(int movieId)
        {
            return new SuccessDataResult<List<GenreOfMovie>>(_genreOfMovie.GetAll(p=>p.MovieId == movieId), Messages.Listed);

        }

        public IDataResult<List<GenreOfMovie>> GetByTypeId(int typeId)
        {
            return new SuccessDataResult<List<GenreOfMovie>>(_genreOfMovie.GetAll(p => p.MovieTypeId == typeId), Messages.Listed);
        }
    }
}
