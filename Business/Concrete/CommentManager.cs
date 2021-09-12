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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IResult Add(Comment comment)
        {
           _commentDal.Add(comment);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<Comment>> GetByMovieId(int movieId)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(p => p.MovieId == movieId));

        }
    }
}
