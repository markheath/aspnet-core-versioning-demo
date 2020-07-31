using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VersioningDemo.Models.V1;

namespace VersioningDemo.Controllers.V1
{
    [ApiVersion("1.0")]
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
                Summary = SampleData.Summaries[rng.Next(SampleData.Summaries.Length)]
            })
            .ToArray();
        }
    }
}
