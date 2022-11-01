using AutoMapper;
using CinemaNet.Abstractions.Models.Movie;
using ScreeningModel = CinemaNet.Persistence.Models.Screening;

namespace CinemaNet.Infrastructure.Mapping;

public class ScreeningProfile : Profile
{
    public ScreeningProfile()
    {
        CreateMap<ScreeningModel, MovieScreening>();
    }
}