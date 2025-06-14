using TemperatureApi.Models;

namespace TemperatureApi.Services
{
    public interface ITemperatureService
    {
        Task<double> GetCurrentTemperatureAsync();
    }
    public class TemperatureService: ITemperatureService
    {
        private readonly Random _random = new();

        public Task<double> GetCurrentTemperatureAsync()
        {     
               double temparature= Math.Round(_random.NextDouble() * (45 - 15) + 15, 1);
               return Task.FromResult(temparature);
        
        }
    }
}
