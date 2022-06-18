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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using RestApi.Utility;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("api/animalType")]
    public class AnimalTypeController : ControllerBase
    {
        private IRepositoryManager _repository;
      

        public AnimalTypeController(IRepositoryManager repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAnimalTypes()
        {
            var animalType=await _repository.AnimalType.GetAllAnimalTypes(false);
            return Ok(animalType);
        }

    //Add Authorize
        [HttpPost]
        public async Task<IActionResult> PostAnimalType(String animalType)
        {
            if(animalType == "")
            {
               return BadRequest("Animal type must have value");
            }

            var allAnimalType=await _repository.AnimalType.GetAllAnimalTypes(false);
            var result=allAnimalType.Where(x => x.Value ==animalType).ToArray();
            if(result.Length > 0) 
            {
                return BadRequest("This animal type is already in database");
            }


            var newAnimalType=new AnimalType();
            newAnimalType.Value=animalType;

            _repository.AnimalType.Create(newAnimalType);
            await _repository.SaveAsync();


            return StatusCode(201, newAnimalType);
        }
    }
}
