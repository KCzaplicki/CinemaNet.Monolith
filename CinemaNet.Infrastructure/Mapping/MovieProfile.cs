using AutoMapper;
using CinemaNet.Abstractions.Models.Movie;
using CinemaNet.Infrastructure.Mapping.Resolvers;
using Movie = CinemaNet.Abstractions.Models.Movie.Movie;
using MovieModel = CinemaNet.Persistence.Models.Movie;

namespace CinemaNet.Infrastructure.Mapping;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<MovieModel, Movie>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(c => c.Category.Name))
            .ForMember(dest => dest.PictureUrl, opt => opt.MapFrom(c => c.Media.FirstOrDefault().Url));

        CreateMap<MovieModel, MovieDetails>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(c => c.Category.Name))
            .ForMember(dest => dest.MediaUrls, opt => opt.MapFrom(c => c.Media.Select(i => i.Url).ToArray()))
            .ForMember(dest => dest.Director, opt => opt.MapFrom<DirectorResolver>())
            .ForMember(dest => dest.Staff, opt => opt.MapFrom<StaffResolver>());

    }
}