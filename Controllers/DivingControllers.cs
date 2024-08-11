using Microsoft.AspNetCore.Mvc;
using Diving.Services;
using Diving.Models;

namespace AfredAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivingControllers : Controller
    {
        private readonly WeatherService _weatherService;

        public DivingControllers(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        // GET api/Diving/divingForecast
        [HttpGet("divingForecast")]
        public async Task<ActionResult<WeatherData[]>> GetForecast()
        {
            var forecast = await _weatherService.GetWeatherDataAsync();
            return Ok(forecast);
        }
    }
}
