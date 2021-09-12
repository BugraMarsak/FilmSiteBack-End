using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieTypeController : Controller
    {
        IMovieTypeService _movieTypeService;

        public MovieTypeController(IMovieTypeService movieTypeService)
        {
            _movieTypeService = movieTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _movieTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _movieTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
