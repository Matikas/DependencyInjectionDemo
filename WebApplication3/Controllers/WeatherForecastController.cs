using Microsoft.AspNetCore.Mvc;
using WebApplication3.DataAccess;
using WebApplication3.TimeService;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherRepository _weatherRepository;
        private readonly IDateTimeService _dateTimeService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, 
            IWeatherRepository weatherRepository,
            IDateTimeService dateTimeService)
        {
            _logger = logger;
            _weatherRepository = weatherRepository;
            _dateTimeService = dateTimeService;
        }

        // [GET] https://localhost:7082/WeatherForecast?city=Vilnius
        [HttpGet]//[HttpDelete]
        public IEnumerable<WeatherForecast> GetFromQuery(string city, string region)
        {
            _logger.LogInformation($"Time is:{_dateTimeService.GetNow()}");
            return _weatherRepository.GetWeather(city, region);
        }

        // [GET] https://localhost:7082/WeatherForecast/Vilnius
        [HttpGet("{city}/{region}")]//[HttpDelete]
        public IEnumerable<WeatherForecast> GetFromRoute(string city, string region)
        {
            return _weatherRepository.GetWeather(city, region);
        }

        [HttpPost]//[HttpPut]
        public IEnumerable<WeatherForecast> Post(WeatherRequest request)
        {
            return _weatherRepository.GetWeather(request.City, request.Region);
        }
    }
}