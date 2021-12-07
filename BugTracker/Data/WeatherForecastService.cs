using BugTracker.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //create a type Task  Class (specifically WeatherForcast task class type) called GetForecastAsync that accepts a DateTime variable
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            //returns 5 different WeatherForecasts containing the Date, TemperatureC, and Summary to an array
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                //TemperatureC is between -20 and 55
                TemperatureC = rng.Next(-20, 55),
                //Summary is pulled from the above list Summaries, with the max index being the length of the list
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
