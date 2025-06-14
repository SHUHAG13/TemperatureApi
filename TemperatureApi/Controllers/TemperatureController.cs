using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TemperatureApi.Services;

namespace TemperatureApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private readonly ITemperatureService _temperatureService;
        private readonly ILogger<TemperatureController> _logger;

        public TemperatureController(ITemperatureService temperatureService, ILogger<TemperatureController> logger)
        {
            _temperatureService = temperatureService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var temperature = await _temperatureService.GetCurrentTemperatureAsync();
                var response = new
                {
                    temperature,
                    unit = "celsius",
                    timestamp = DateTime.UtcNow.ToString("o")
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while generating temperature");
                return StatusCode(500, new { error = "Internal Server Error" });
            }
        }

    }
}
