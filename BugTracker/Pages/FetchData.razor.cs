using BugTracker.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BugTracker.Pages
{
    public partial class FetchData
    {
        [Inject]
        WeatherForecastService ForecastService { get; set; }

        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}

