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
    public class ArtistManager :IArtistService
    {
        IArtistDal _artistDal;

        public ArtistManager(IArtistDal artistDal)
        {
            _artistDal = artistDal;
        }

        public IResult Add(Artist artist)
        {
            _artistDal.Add(artist);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<Artist>> GetAll()
        {
            return new SuccessDataResult<List<Artist>>(_artistDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Artist> GetById(int artistId)
        {
            return new SuccessDataResult<Artist>(_artistDal.Get(p => p.ArtistId == artistId));
        }
    }
}
