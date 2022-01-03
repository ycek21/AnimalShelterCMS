using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private ILoggerManager _logger;
        private IRepositoryManager _repository;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastController(ILoggerManager logger, IRepositoryManager repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // _logger.LogInfo("Here is info message from our values controller.");
            // _logger.LogDebug("Here is debug message from our values controller.");
            // _logger.LogWarn("Here is warn message from our values controller.");
            // _logger.LogError("Here is an error message from our values controller.");
            var jacek = await _repository.User.GetAllUsersAsync(false);
            return Ok(jacek);

        }
    }
}
