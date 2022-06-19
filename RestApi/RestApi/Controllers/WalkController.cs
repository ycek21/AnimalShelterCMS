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
    [Route("api/walks")]
    public class WalkController : ControllerBase
    {
        private IRepositoryManager _repository;

        private readonly IMapper _mapper;
        private readonly IAuthenticationManager _authManager;


        public WalkController(IRepositoryManager repository, IMapper mapper, IAuthenticationManager authManager)
        {
            _repository = repository;
            _mapper = mapper;
            _authManager = authManager;
        }


        [HttpGet("{animalId}", Name = "GetAnimalWalks")]
        public async Task<IActionResult> GetAnimalWalks(Guid animalId)
        {
            var walks = await _repository.Walk.GetAnimalWalks(animalId, false);
            var walksDto = _mapper.Map<IEnumerable<WalkDto>>(walks);
            return Ok(walksDto);
        }

        [HttpDelete("{walkId}", Name = "DeleteWalk"), Authorize(Roles = "CommonUser, Administrator")]
        public async Task<IActionResult> DeleteWalk(Guid walkId)
        {
            var token = Request.Headers[HeaderNames.Authorization].ToString().Remove(0, 7);
            var email = _authManager.GetUserEmail(token);
            var userId = await _authManager.GetUserId(email);
            var userRoles = await _authManager.GetUserRoles(token);

            var walk = _repository.Walk.FindByCondition(x => x.Id == walkId, false).FirstOrDefault();

            if (userRoles.Contains("CommonUser") && walk.UserId != userId)
            {
                return StatusCode(403, "User is not a walk owner");
            }

            if (walk == null)
            {
                return NotFound();
            }

            _repository.Walk.DeleteWalk(walk);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost, Authorize(Roles = "CommonUser, Administrator")]
        public async Task<IActionResult> PostWalk(WalkForCreationDto walkForCreation)
        {
            if (walkForCreation == null)
            {
                return BadRequest("walkForCreation object is null");
            }

            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }
            var userId = "";


            var result = _repository.Walk.FindByCondition(x => x.Date == walkForCreation.DateOfWalk, false).FirstOrDefault();
            if (result != null)
            {
                return BadRequest("This date is already reserved ");
            }

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

            var walk = _mapper.Map<Walk>(walkForCreation);
            walk.UserId = userId;
            walk.Accepted = true;

            _repository.Walk.Create(walk);
            await _repository.SaveAsync();


            return StatusCode(201, walk);
        }
    }
}