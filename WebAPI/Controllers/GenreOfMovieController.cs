using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreOfMovieController : Controller
    {
        IGenreOfMovieService _genreOfMovieService;

        public GenreOfMovieController(IGenreOfMovieService genreOfMovieService)
        {
            _genreOfMovieService = genreOfMovieService;
        }
                
        [HttpGet("getbymovieid")]
        public IActionResult GetByMovieId(int id)
        {
            var result =_genreOfMovieService.GetByMovieId(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbytypeid")]
        public IActionResult GetByTypeId(int id)
        {
            var result = _genreOfMovieService.GetByTypeId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult add(GenreOfMovie genreOfMovie)
        {
            var result = _genreOfMovieService.Add(genreOfMovie);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
