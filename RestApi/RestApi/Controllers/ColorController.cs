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
    [Route("api/color")]
    public class ColorController : ControllerBase
    {
        private IRepositoryManager _repository;
      

        public ColorController(IRepositoryManager repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllColors()
        {
            var colors=await _repository.Color.GetAllColors(false);
            return Ok(colors);
        }

    //Add Authorize
        [HttpPost]
        public async Task<IActionResult> PostColor(String color)
        {
            if(color == "")
            {
               return BadRequest("Color must have value");
            }

            var allColors=await _repository.Color.GetAllColors(false);
            var result=allColors.Where(x => x.Value ==color).ToArray();
            if(result.Length > 0) 
            {
                return BadRequest("This size is already in database");
            }


            var newColor=new Color();
            newColor.Value=color;

            _repository.Color.Create(newColor);
            await _repository.SaveAsync();


            return StatusCode(201, newColor);
        }
    }
}
