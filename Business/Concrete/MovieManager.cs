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
    public class MovieManager : IMovieService
    {
        IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public IResult Add(Movie movie)
        {
            _movieDal.Add(movie);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<Movie>> GetAll()
        {
            return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Movie> GetById(int movieId)
        {
            return new SuccessDataResult<Movie>(_movieDal.Get(p => p.MovieId == movieId));

        }
    }
}
