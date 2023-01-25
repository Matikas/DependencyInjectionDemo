using WebApplication3.TimeService;

namespace WebApplication3.DataAccess
{
    public class WeatherRepository : IWeatherRepository
    {
        private Guid _id;

        private readonly IDateTimeService _dateTimeService;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherRepository(IDateTimeService dateTimeService)
        {
            _id = Guid.NewGuid();
            _dateTimeService = dateTimeService;
        }

        public List<WeatherForecast> GetWeather(string city, string region)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = _dateTimeService.GetNow().AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToList();
        }
    }
}
