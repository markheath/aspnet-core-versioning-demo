using System;

namespace VersioningDemo.Models.V2
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public string Location { get; set; }

        public int WindSpeed { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

}
