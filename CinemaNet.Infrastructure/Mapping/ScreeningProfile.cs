using AutoMapper;
using CinemaNet.Abstractions.Models.Movie;
using Screening = CinemaNet.Abstractions.Models.Screening.Screening;
using ScreeningModel = CinemaNet.Persistence.Models.Screening;

namespace CinemaNet.Infrastructure.Mapping;

public class ScreeningProfile : Profile
{
    public ScreeningProfile()
    {
        CreateMap<ScreeningModel, MovieScreening>();

        CreateMap<ScreeningModel, Screening>()
            .ForMember(dest => dest.MovieName, opt => opt.MapFrom(c => c.Movie.Name))
            .ForMember(dest => dest.CinemaHallName, opt => opt.MapFrom(c => c.CinemaHall.Name))
            .ForMember(dest => dest.CinemaHallRows, opt => opt.MapFrom(c => c.CinemaHall.Rows.OrderBy(r => r.Letter)));
    }
}