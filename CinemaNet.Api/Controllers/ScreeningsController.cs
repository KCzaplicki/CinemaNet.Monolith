using AutoMapper;
using CinemaNet.Abstractions.Models.Screening;
using CinemaNet.Abstractions.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaNet.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ScreeningsController : ControllerBase
{
    private readonly IScreeningReadOnlyRepository _screeningReadOnlyRepository;
    private readonly IMapper _mapper;

    public ScreeningsController(IScreeningReadOnlyRepository screeningReadOnlyRepository, IMapper mapper)
    {
        _screeningReadOnlyRepository = screeningReadOnlyRepository;
        _mapper = mapper;
    }
    
    [HttpGet("{id}")]
    public IActionResult GetScreening(string id)
    {
        if (!_screeningReadOnlyRepository.Exists(id))
        {
            return NotFound();
        }

        var screeningModel = _screeningReadOnlyRepository.GetScreeningDetails(id);
        var mappedScreening = _mapper.Map<Screening>(screeningModel);

        return Ok(mappedScreening);
    }
}