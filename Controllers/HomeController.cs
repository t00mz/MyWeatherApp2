using Microsoft.AspNetCore.Mvc;
using MyWeatherApp2.Logic;
using MyWeatherApp2.Models;
using System.Diagnostics;

namespace MyWeatherApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWeatherApi weatherApi;

        public HomeController(ILogger<HomeController> logger, IWeatherApi weatherResponse)
        {
            _logger = logger;
            weatherApi = weatherResponse;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult SunnyWeather(ForecastModel forecast)
        //{
        //    return View(forecast);
        //}
        //public IActionResult RainyWeather(ForecastModel forecast)
        //{
        //    return View(forecast);
        //}
        //public IActionResult WindyWeather(ForecastModel forecast)
        //{
        //    return View(forecast);
        //}

        public IActionResult WeatherForecast(string zipCode)
        {
   
            var forecastModel = weatherApi.GetForecast(zipCode);

            
            if(forecastModel == null)
            {
                return View("InvalidZip");
            }
            if (string.IsNullOrWhiteSpace(forecastModel.Name))
            {
                forecastModel.Name = "Default"; 
            }
            if(forecastModel.Text == "Mist")
            {
                return View("MistWeather", forecastModel); 
            }

            //if (string.IsNullOrWhiteSpace(forecastModel.Region))
            //{
            //    forecastModel.Region = "Developer Changed the API";
            //}

            return View(forecastModel);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}