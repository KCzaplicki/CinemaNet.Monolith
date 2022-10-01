using Microsoft.AspNetCore.Mvc;

namespace CinemaNet.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string Get() => "Hello";
}