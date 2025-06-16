using Microsoft.AspNetCore.Mvc;
using TemperatureApi.Models;
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
                var temperatureData = await _temperatureService.GetCurrentTemperatureAsync();
                return Ok(temperatureData);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while generating temperature");
                return StatusCode(500, new { error = "Internal Server Error" });
            }
        }
    }
}
