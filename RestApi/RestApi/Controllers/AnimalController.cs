using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;

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

        public AnimalController(ILoggerManager logger, IRepositoryManager repository, IMapper mapper, IAuthenticationManager authManager)
        {
            _repository = repository;
            _mapper = mapper;
            _authManager = authManager;
        }

        [HttpGet, Authorize]
        public async Task<IActionResult> GetAllAnimals([FromQuery] AnimalParameters animalParameters)
        {

            try
            {

                var animals = await _repository.Animal.GetAllAnimalsWithFilterAsync(false, animalParameters);

                Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(animals.MetaData));

                var animalDto = _mapper.Map<IEnumerable<AnimalForAnimalListDto>>(animals);

                return Ok(animalDto);

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);

                return BadRequest();
            }
        }

        [HttpGet("{animalId}", Name = "GetAnimalById"), Authorize]
        public async Task<IActionResult> GetAnimalById(Guid animalId)
        {
            var animal = await _repository.Animal.GetAnimalById(animalId, false);

            if (animal == null)
            {
                return NotFound("Animal with such Id doesn't exist");
            }

            var animalDto = _mapper.Map<AnimalDto>(animal);

            return Ok(animalDto);
        }

        [HttpPost, Authorize]
        public async Task<IActionResult> PostAnAnimal([FromBody] AnimalForCreationDto animalForCreation)
        {
            if (animalForCreation == null)
            {
                return BadRequest("animalForCreation object is null");
            }

            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }

            var userId = "";
            try
            {
                var token = Request.Headers[HeaderNames.Authorization].ToString().Remove(0, 7);
                var email = _authManager.GetUserEmail(token);
                userId = await _authManager.GetUserId(email);
            }
            catch (System.Exception)
            {
                BadRequest(new { message = "Wrong payload" });
            }

            var animal = _mapper.Map<Animal>(animalForCreation);
            animal.ModifiedBy = userId;

            _repository.Animal.Create(animal);
            await _repository.SaveAsync();

            var animalToReturn = _mapper.Map<AnimalDto>(animal);

            return StatusCode(201, animalToReturn);
        }
    }
}
