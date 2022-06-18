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
    [Route("api/size")]
    public class SizeController : ControllerBase
    {
        private IRepositoryManager _repository;
      

        public SizeController(IRepositoryManager repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllSizes()
        {
            var sizes=await _repository.Size.GetAllSizes(false);
            return Ok(sizes);
        }

        [HttpPost,Authorize(Roles = "Administrator")]
        public async Task<IActionResult> PostSize(String size)
        {
            if(size == "")
            {
               return BadRequest("Size must have value");
            }

            var allSizes=await _repository.Size.GetAllSizes(false);
            var result=allSizes.Where(x => x.Value ==size).ToArray();
            if(result.Length > 0) 
            {
                return BadRequest("This size is already in database");
            }
           
            var newSize=new Size();
            newSize.Value=size;

            _repository.Size.Create(newSize);
            await _repository.SaveAsync();


            return StatusCode(201, newSize);
        }
    }
}
