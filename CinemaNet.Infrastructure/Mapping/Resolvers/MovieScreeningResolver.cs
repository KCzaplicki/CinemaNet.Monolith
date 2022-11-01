using AutoMapper;
using CinemaNet.Abstractions.Models.Movie;
using Movie = CinemaNet.Persistence.Models.Movie;
using ScreeningModel = CinemaNet.Persistence.Models.Screening;

namespace CinemaNet.Infrastructure.Mapping.Resolvers;

public class MovieScreeningResolver<TDestination> : IValueResolver<Movie, TDestination, MovieScreenings[]>
{
    public MovieScreenings[] Resolve(Movie source, TDestination destination, MovieScreenings[] destMember, ResolutionContext context) 
        => source.Screenings.GroupBy(s => s.StartDate.Date)
                            .OrderBy(s => s.Key)
                            .Select(s => new MovieScreenings
                            {
                                Day = s.Key,
                                Screenings = s.Select(x => context.Mapper.Map<MovieScreening>(x))
                                              .OrderBy(x => x.StartDate)
                                              .ToArray()
                            })
                            .ToArray();
}