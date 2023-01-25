namespace WebApplication3.DataAccess
{
    public interface IWeatherRepository
    {
        List<WeatherForecast> GetWeather(string city, string region);
    }
}
