using System;
using System.Threading.Tasks;

namespace Exercises1.Data
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate, int amount = 5);
    }
}