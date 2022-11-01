using AutoMapper;
using CinemaNet.Abstractions.Models.Movie;
using CinemaNet.Abstractions.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaNet.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMovieReadOnlyRepository _movieReadOnlyRepository;
    private readonly IMapper _mapper;

    public MoviesController(IMovieReadOnlyRepository movieReadOnlyRepository, IMapper mapper)
    {
        _movieReadOnlyRepository = movieReadOnlyRepository;
        _mapper = mapper;
    }
    
    [HttpGet("Weekly")]
    public Movie[] GetWeeklyMovies()
    {
        var movieModels = _movieReadOnlyRepository.GetWeeklyMovies();
        var mappedMovies = _mapper.Map<Movie[]>(movieModels);

        return mappedMovies;
    }
    
    [HttpGet("{id}")]
    public IActionResult GetMovieDetails(string id)
    {
        if (!_movieReadOnlyRepository.Exists(id))
        {
            return NotFound();
        }
        
        var movieModel = _movieReadOnlyRepository.GetMovieDetails(id);
        var mappedMovie = _mapper.Map<MovieDetails>(movieModel);

        return Ok(mappedMovie);
    }
}