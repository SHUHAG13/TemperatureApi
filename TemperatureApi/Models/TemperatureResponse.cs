namespace TemperatureApi.Models
{
    public class TemperatureResponse
    {
        public double Temperature { get; set; }
        public string Unit { get; set; } = "celsius";
        public string Timestamp { get; set; } = DateTime.UtcNow.ToString("o");

        
    }
}
