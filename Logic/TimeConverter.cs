using System.Globalization;

namespace MyWeatherApp2.Logic
{
    public class TimeConverter
    {
        public static string TimeConverterM(string Localtime)
        {
            var result = Convert.ToDateTime(Localtime);
            string finalResult = result.ToString("hh:mm tt", CultureInfo.CurrentCulture);
            return finalResult;
        }
    }
}
