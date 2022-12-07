using Microsoft.AspNetCore.Mvc;
using MyWeatherApp2.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyWeatherApp2.Logic
{
    public class WeatherApi : IWeatherApi
    {
        private HttpClient _client = new HttpClient();
        public WeatherApi() { }

        public ForecastModel GetForecast(string zipCode)
        {

            var key = File.ReadAllText("appsettings.json");
            var apiKey2 = JObject.Parse(key).GetValue("apiKey").ToString();
     
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://weatherapi-com.p.rapidapi.com/forecast.json?q={zipCode}&days=3"),
                Headers =
                {
                    { "X-RapidAPI-Key", $"{apiKey2}" },
                    //{ "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
                },
            };

            using (var response = _client.SendAsync(request).Result)
            {
                try
                {
                    response.EnsureSuccessStatusCode();

                    var body = response.Content.ReadAsStringAsync().Result;

                    var forecast = JsonConvert.DeserializeObject<WeatherResults>(body);

                    var forecastModel = new ForecastModel();

                    forecastModel.Text = forecast.current.condition.text;
                    forecastModel.Icon = forecast.current.condition.icon;
                    forecastModel.Temp_f = forecast.current.temp_f;
                    forecastModel.Feelslike_f = forecast.current.feelslike_f;
                    forecastModel.Wind_mph = forecast.current.wind_mph;
                    forecastModel.Wind_dir = forecast.current.wind_dir;
                    forecastModel.Humidity = forecast.current.humidity;
                    forecastModel.Cloud = forecast.current.cloud;
                    foreach (var item in forecast.forecast.forecastday) { forecastModel.Sunrise = item.astro.sunrise; };
                    foreach (var item in forecast.forecast.forecastday) { forecastModel.Sunset = item.astro.sunset; };
                    forecastModel.Code = forecast.current.condition.code;
                    forecastModel.Name = forecast.location.name;
                    forecastModel.Region = forecast.location.region;
                    forecastModel.Country = forecast.location.country;
                    forecastModel.Localtime = forecast.location.localtime;

                    return forecastModel;
                }
                catch
                {
                    return null;
                }
            }
        }

        public ForecastModel GetForecastById(int id)
        {
            throw new NotImplementedException();
        }
    }
}