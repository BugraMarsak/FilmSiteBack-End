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
    public class MovieAndArtistController : Controller
    {
        IMovieAndArtistService _movieAndArtistService;

        public MovieAndArtistController(IMovieAndArtistService movieAndArtistService)
        {
            _movieAndArtistService = movieAndArtistService;
        }

        [HttpGet("getbyartistid")]
        public IActionResult GetByArtistId(int id)
        {
            var result = _movieAndArtistService.GetByArtistId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbymovieid")]
        public IActionResult GetByMovieId(int id)
        {
            var result = _movieAndArtistService.GetByMovieId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult add(MovieAndArtist movieAndArtist)
        {
            var result = _movieAndArtistService.Add(movieAndArtist);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
