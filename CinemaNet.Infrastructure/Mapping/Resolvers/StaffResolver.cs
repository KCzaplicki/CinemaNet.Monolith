using AutoMapper;
using CinemaNet.Abstractions.Models.Movie;
using Movie = CinemaNet.Persistence.Models.Movie;

namespace CinemaNet.Infrastructure.Mapping.Resolvers;

public class StaffResolver : IValueResolver<Movie, MovieDetails, string[]>
{
    public string[] Resolve(Movie source, MovieDetails destination, string[] destMember, ResolutionContext context)
    {
        return source.Staff
            .Where(s => s.Role != "Director")
            .Select(s => $"{s.Staff.FirstName} {s.Staff.LastName}")
            .ToArray();
    }
}