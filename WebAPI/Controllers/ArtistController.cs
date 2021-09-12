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
    public class ArtistController : Controller
    {
        IArtistService _artistService;

        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _artistService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _artistService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult add(Artist artist)
        {
            var result = _artistService.Add(artist);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
