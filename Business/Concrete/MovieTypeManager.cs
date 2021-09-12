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
    class MovieTypeManager : IMovieTypeService
    {
        IMovieTypeDal _movieTypeDal;

        public MovieTypeManager(IMovieTypeDal movieTypeDal)
        {
            _movieTypeDal = movieTypeDal;
        }

        public IDataResult<List<MovieType>> GetAll()
        {
            return new SuccessDataResult<List<MovieType>>(_movieTypeDal.GetAll(), Messages.Listed);
        }

        public IDataResult<MovieType> GetById(int Id)
        {
            return new SuccessDataResult<MovieType>(_movieTypeDal.Get(p => p.MovieTypeId == Id));

        }
    }
}
