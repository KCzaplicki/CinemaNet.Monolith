using CinemaNet.Abstractions.Repositories;
using CinemaNet.Infrastructure.Persistence;
using CinemaNet.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaNet.Infrastructure.Repositories;

public class MovieReadOnlyRepository : IMovieReadOnlyRepository
{
    private readonly DbSet<Movie> _movies;

    public MovieReadOnlyRepository(CinemaNetContext context)
    {
        _movies = context.Movies;
    }

    public IQueryable<Movie> GetAll() => _movies;

    public Movie Get(string id) => 
        _movies.FirstOrDefault(m => m.Id == id);

    public bool Exists(string id) => 
        _movies.Any(m => m.Id == id);
    
    public IList<Movie> GetWeeklyMovies()
    {
        var movies = _movies.Where(m => m.State == MovieState.Published)
            .OrderByDescending(m => m.ReleaseDate)
            .Include(m => m.Category)
            .Include(m => m.Media)
            .Include(m => m.Screenings)
            .ToList();

        return movies;
    }
    
    public Movie GetMovieDetails(string id)
    {
        var movie = _movies
            .Include(m => m.Category)
            .Include(m => m.Media)
            .Include(m => m.Screenings)
            .Include(m => m.Staff)
            .ThenInclude(s => s.Staff)
            .FirstOrDefault(m => m.Id == id);

        return movie;
    }
}