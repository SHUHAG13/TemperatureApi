using TemperatureApi.Models;

namespace TemperatureApi.Services
{
    public interface ITemperatureService
    {
        Task<TemperatureResponse> GetCurrentTemperatureAsync();
    }

    public class TemperatureService : ITemperatureService
    {
        private readonly Random _random = new();

        public async Task<TemperatureResponse> GetCurrentTemperatureAsync()
        {
            double temperature = Math.Round(_random.NextDouble() * (45 - 15) + 15, 1);

            var response = new TemperatureResponse
            {
                Temperature = temperature,
                Timestamp = DateTime.UtcNow.ToString("o")
            };

            return await Task.FromResult(response);
        }
    }
}
