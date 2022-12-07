namespace MyWeatherApp2.Models
{
    public class ForecastModel
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }


        // might remove

        public string Localtime { get; set; }

        // current

        public string Text { get; set; }
        public string Icon { get; set; }
        public double Temp_f { get; set; }
        public double Feelslike_f { get; set; }
        public double Wind_mph { get; set; }
        public string Wind_dir { get; set; }
        public double Humidity { get; set; }
        public double Cloud { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public double Code { get; set; }

        //day





    }
}
