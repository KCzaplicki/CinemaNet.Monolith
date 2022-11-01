using AutoMapper;
using CinemaNet.Abstractions;
using CinemaNet.Abstractions.Models.Movie;
using MovieModel = CinemaNet.Persistence.Models.Movie;

namespace CinemaNet.Infrastructure.Mapping.Resolvers;

public class DirectorResolver : IValueResolver<MovieModel, MovieDetails, string>
{
    public string Resolve(MovieModel source, MovieDetails destination, string destMember, ResolutionContext context) 
        => source.Staff.Where(s => s.Role == Constants.StaffTypes.Director)
                       .Select(s => $"{s.Staff.FirstName} {s.Staff.LastName}")
                       .FirstOrDefault();
}