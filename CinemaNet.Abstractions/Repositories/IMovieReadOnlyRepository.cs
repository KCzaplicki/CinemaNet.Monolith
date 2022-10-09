using CinemaNet.Common.Persistence;
using CinemaNet.Persistence.Models;

namespace CinemaNet.Abstractions.Repositories;

public interface IMovieReadOnlyRepository : IReadOnlyRepository<Movie>
{
    Movie GetMovieDetails(string id);
    
    IList<Movie> GetWeeklyMovies();
}