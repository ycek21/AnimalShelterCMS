using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repository;
        private readonly UserManager<User> _userManager;

        public UserController(UserManager<User> userManager, IMapper mapper, ILoggerManager logger, IRepositoryManager repository)
        {
            _mapper = mapper;
            _logger = logger;
            _repository = repository;
            _userManager = userManager;
        }

        [HttpDelete("{id}"), Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _repository.User.GetUserAsync(id, trackChanges: false);

            if (user == null)
            {
                return NotFound();
            }

            _repository.User.DeleteUser(user);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpGet, Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetAllUsers(bool trackChanges)
        {
            var users = await _userManager.Users.ToListAsync();
            List<UserDto> userToReturn = new List<UserDto>();

            foreach (var user in users)
            {
                var userRole = await _userManager.GetRolesAsync(user);
                var userDto = _mapper.Map<UserDto>(user);
                userDto.Roles = userRole.ToList();
                userToReturn.Add(userDto);
            }

            var usersDto = _mapper.Map<List<UserDto>>(users);

            return Ok(userToReturn);

        }


        [HttpGet("{userId}/walks", Name = "GetUserWalks"), Authorize(Roles = "Administrator, CommonUser")]
        public async Task<IActionResult> GetUserWalks(Guid userId)
        {
            var user = await _repository.User.GetUserWithWalksAsync(userId.ToString(), false);

            List<WalkAssignedToUserDto> walksToReturn = new List<WalkAssignedToUserDto>();

            foreach (var userWalk in user.Walks)
            {
                var animal = await _repository.Animal.GetAnimalById(userWalk.AnimalId, false);

                var animalForUserWalkDto = _mapper.Map<AnimalForUserWalkDto>(animal);
                var walkAsDto = _mapper.Map<WalkAssignedToUserDto>(userWalk);

                walkAsDto.Animal = animalForUserWalkDto;
                walksToReturn.Add(walkAsDto);
            }

            return Ok(walksToReturn);

        }

        [HttpPatch("{Id}"), Authorize(Roles = "Administrator")]
        public async Task<IActionResult> PatchUserRole(string Id, [FromBody] RoleForPatchDto role)
        {
            if (role.Role == null || role.Role == "")
            {
                _logger.LogError("role object sent from client is null.");
                return BadRequest("role object is null");
            }

            var users = await _userManager.Users.ToListAsync();
            var lookedForUser = users.Find(u => u.Id == Id);

            if (lookedForUser == null)
            {
                _logger.LogError($"User with such Id doesn't exist.{Id}");
                return BadRequest("User with such Id doesn't exist.");
            }

            var userRoles = await _userManager.GetRolesAsync(lookedForUser);
            if (userRoles.Count > 0)
            {
                var roleToDelete = userRoles[0] == "CommonUser" ? "COMMON" : "ADMIN";
                await _userManager.RemoveFromRoleAsync(lookedForUser, roleToDelete);
            }



            await _userManager.AddToRoleAsync(lookedForUser, role.Role);

            var newUserRole = await _userManager.GetRolesAsync(lookedForUser);

            return NoContent();
        }

    }
}
