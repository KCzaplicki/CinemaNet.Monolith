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
    
    public IList<Movie> GetWeeklyMovies() =>
        _movies.Where(m => m.State == MovieState.Published)
            .Include(m => m.Category)
            .Include(m => m.Media)
            .ToList();

    public Movie GetMovieDetails(string id) =>
        _movies
            .Include(m => m.Category)
            .Include(m => m.Media)
            .Include(m => m.Staff)
            .ThenInclude(s => s.Staff)
            .FirstOrDefault(m => m.Id == id);
}