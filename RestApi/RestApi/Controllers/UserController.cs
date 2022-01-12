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

        [HttpDelete("id")]
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

        // [HttpPatch]
        // public async Task<IActionResult> ChangeUserRole(IdentityRole role)
        // {

        // }

    }
}
