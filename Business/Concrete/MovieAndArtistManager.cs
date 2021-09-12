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
    public class MovieAndArtistManager : IMovieAndArtistService
    {
        IMovieAndArtistDal _movieAndArtistDal;

        public MovieAndArtistManager(IMovieAndArtistDal movieAndArtistDal)
        {
            _movieAndArtistDal = movieAndArtistDal;
        }

        public IResult Add(MovieAndArtist movieAndArtist)
        {
            _movieAndArtistDal.Add(movieAndArtist);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<MovieAndArtist>> GetByArtistId(int artistId)
        {
            return new SuccessDataResult<List<MovieAndArtist>>(_movieAndArtistDal.GetAll(p => p.ArtistId == artistId));

        }

        public IDataResult<List<MovieAndArtist>> GetByMovieId(int movieId)
        {
            return new SuccessDataResult<List<MovieAndArtist>>(_movieAndArtistDal.GetAll(p => p.MovieId == movieId));

        }
    }
}
