using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VersioningDemo.Models.V2;

namespace VersioningDemo.Controllers.V2
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = SampleData.Summaries[rng.Next(SampleData.Summaries.Length)],
                WindSpeed = rng.Next(5,50),
                Location = SampleData.Locations[rng.Next(SampleData.Locations.Length)],
            })
            .ToArray();
        }
    }
}
