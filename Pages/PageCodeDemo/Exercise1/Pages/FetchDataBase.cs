using Exercise1.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Pages
{
    public class FetchDataBase : ComponentBase
    {
        [Inject]
        public WeatherForecastService ForecastService { get; set; }
        protected WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
