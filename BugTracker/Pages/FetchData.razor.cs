using BugTracker.Data;
using BugTracker.Data.Entities;
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

        [Parameter]
        public EventCallback<bool> OnClose { get; set; }
        private Task ModalCancel()
        {
            return OnClose.InvokeAsync(false);
        }

        private Task ModalOk()
        {
            return OnClose.InvokeAsync(true);
        }
    }
}

