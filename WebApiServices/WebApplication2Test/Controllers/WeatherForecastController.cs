using Microsoft.AspNetCore.Mvc;
using CARSO.AppService;
using CARSO.AppService.ServiceDataContainers;
using CARSO.AppService.Provider.Service;

namespace WebApplication2Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}


        [HttpGet("GetUsuariosTest")]
        public IActionResult GetUsuariosTest()
        {
            Usuario usuarioTest = new Usuario();
            AppService app = new AppService();
            app.GetUsuarioByKey("c.torres", ref usuarioTest);
            return Ok(usuarioTest);


        }

    }
}