namespace WebApplication3
{
    public class WeatherRequest : IWeatherRequest
    {
        public string City { get; set; }
        public string Region { get; set; }
    }
}
