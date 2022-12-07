﻿// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class WeatherResults
{
    public Location location { get; set; }
    public Current current { get; set; }
    public Forecast forecast { get; set; }
}
public class Astro
{
    public string sunrise { get; set; }
    public string sunset { get; set; }
    public string moonrise { get; set; }
    public string moonset { get; set; }
    public string moon_phase { get; set; }
    public string moon_illumination { get; set; }
}

public class Condition
{
    public string text { get; set; }
    public string icon { get; set; }
    public double code { get; set; }
}

public class Current
{
    public double last_updated_epoch { get; set; }
    public string last_updated { get; set; }
    public double temp_c { get; set; }
    public double temp_f { get; set; }
    public double is_day { get; set; }
    public Condition condition { get; set; }
    public double wind_mph { get; set; }
    public double wind_kph { get; set; }
    public double wind_degree { get; set; }
    public string wind_dir { get; set; }
    public double pressure_mb { get; set; }
    public double pressure_in { get; set; }
    public double precip_mm { get; set; }
    public double precip_in { get; set; }
    public double humidity { get; set; }
    public double cloud { get; set; }
    public double feelslike_c { get; set; }
    public double feelslike_f { get; set; }
    public double vis_km { get; set; }
    public double vis_miles { get; set; }
    public double uv { get; set; }
    public double gust_mph { get; set; }
    public double gust_kph { get; set; }
}

public class Day
{
    public double maxtemp_c { get; set; }
    public double maxtemp_f { get; set; }
    public double mdoubleemp_c { get; set; }
    public double mdoubleemp_f { get; set; }
    public double avgtemp_c { get; set; }
    public double avgtemp_f { get; set; }
    public double maxwind_mph { get; set; }
    public double maxwind_kph { get; set; }
    public double totalprecip_mm { get; set; }
    public double totalprecip_in { get; set; }
    public double totalsnow_cm { get; set; }
    public double avgvis_km { get; set; }
    public double avgvis_miles { get; set; }
    public double avghumidity { get; set; }
    public double daily_will_it_rain { get; set; }
    public double daily_chance_of_rain { get; set; }
    public double daily_will_it_snow { get; set; }
    public double daily_chance_of_snow { get; set; }
    public Condition condition { get; set; }
    public double uv { get; set; }
}

public class Forecast
{
    public List<Forecastday> forecastday { get; set; }
}

public class Forecastday
{
    public string date { get; set; }
    public double date_epoch { get; set; }
    public Day day { get; set; }
    public Astro astro { get; set; }
    public List<Hour> hour { get; set; }
}

public class Hour
{
    public double time_epoch { get; set; }
    public string time { get; set; }
    public double temp_c { get; set; }
    public double temp_f { get; set; }
    public double is_day { get; set; }
    public Condition condition { get; set; }
    public double wind_mph { get; set; }
    public double wind_kph { get; set; }
    public double wind_degree { get; set; }
    public string wind_dir { get; set; }
    public double pressure_mb { get; set; }
    public double pressure_in { get; set; }
    public double precip_mm { get; set; }
    public double precip_in { get; set; }
    public double humidity { get; set; }
    public double cloud { get; set; }
    public double feelslike_c { get; set; }
    public double feelslike_f { get; set; }
    public double windchill_c { get; set; }
    public double windchill_f { get; set; }
    public double heatindex_c { get; set; }
    public double heatindex_f { get; set; }
    public double dewpodouble_c { get; set; }
    public double dewpodouble_f { get; set; }
    public double will_it_rain { get; set; }
    public double chance_of_rain { get; set; }
    public double will_it_snow { get; set; }
    public double chance_of_snow { get; set; }
    public double vis_km { get; set; }
    public double vis_miles { get; set; }
    public double gust_mph { get; set; }
    public double gust_kph { get; set; }
    public double uv { get; set; }
}

public class Location
{
    public string name { get; set; }
    public string region { get; set; }
    public string country { get; set; }
    public double lat { get; set; }
    public double lon { get; set; }
    public string tz_id { get; set; }
    public double localtime_epoch { get; set; }
    public string localtime { get; set; }
}


