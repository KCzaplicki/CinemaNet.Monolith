using AutoMapper;
using CinemaNet.Abstractions.Models.Screening;
using CinemaNet.Persistence.Models;

namespace CinemaNet.Infrastructure.Mapping;

public class CinemaHallProfile : Profile
{
    public CinemaHallProfile()
    {
        CreateMap<CinemaHallRow, ScreeningCinemaHallRow>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(c => c.Type.ToString()));
    }
}