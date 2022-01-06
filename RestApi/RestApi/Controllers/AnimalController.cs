using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("api/animals")]
    public class AnimalController : ControllerBase
    {

        private ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IAuthenticationManager _authManager;
        private IRepositoryManager _repository;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public AnimalController(ILoggerManager logger, IRepositoryManager repository, IMapper mapper, IAuthenticationManager authManager)
        {
            _repository = repository;
            _mapper = mapper;
            _authManager = authManager;
        }

        [HttpGet, Authorize]
        public async Task<IActionResult> GetAllAnimals()
        {
            try
            {
                var animals = await _repository.Animal.GetAllAnimalsAsync(false);

                var animalDto = _mapper.Map<IEnumerable<AnimalForAnimalListDto>>(animals);

                return Ok(animalDto);

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);

                return BadRequest();
            }


        }
    }
}
