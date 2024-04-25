using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie.API.Dto;
using Movie.API.Services;

namespace Movie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService _service;
        public MoviesController(IMovieService service)
        {
            _service = service;
        }

        [HttpGet("All")]
        public IActionResult GetMovies()
        {
            //List of Movies
            var allMovies = _service.GetAllMovies();

            return Ok(allMovies);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetMovieById(int id)
        {
            var newMovie = _service.GetMovieById(id);

            if (newMovie == null)
                return NotFound($"Movie with id {id} could not be found.");

            return Ok(newMovie);
        }


        [HttpPost]
        public IActionResult AddNewMovie([FromBody] PostMovieDto payload)
        {
            var newMovie = _service.AddMovie(payload);

            return Ok(newMovie);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateMovie([FromBody] PutMovieDto payload, int id)
        {
            var updatedMovie = _service.UpdateMovie(payload, id);

            return Ok(payload);
        }


        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteMovie(int id)
        {
            _service.DeleteMovie(id);

            return Ok();
        }

    }
}