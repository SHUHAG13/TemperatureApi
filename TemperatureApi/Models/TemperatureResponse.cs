namespace TemperatureApi.Models
{
    public class TemperatureResponse
    {
        public double temperature { get; set; }
        public string unit { get; set; } = "celsius";
        public DateTime timestamp { get; set; } = DateTime.UtcNow;
    }
}
