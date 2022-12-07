using MyWeatherApp2.Models;

namespace MyWeatherApp2.Logic
{
    public interface IWeatherApi
    {
        public ForecastModel GetForecast(string zipCode);
        public ForecastModel GetForecastById(int id); 
    }
}
