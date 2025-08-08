using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
    {
        _logger = logger;
        _weatherForecastService = weatherForecastService;
    }

    [HttpPost]
    [Route("generate")]
    public IActionResult Generate([FromQuery] int count, [FromBody] TemperatureRequest request)
    {
        if (count < 0 || request.Max < request.Min)
        {
            return BadRequest("Count has to be positive number, and max must greater than the min value");
        }
        var result = _weatherForecastService.Get(count, request.Min, request.Max);
        return Ok(result);
    }
    
}
