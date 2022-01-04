using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace RestApi.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly UserManager<User> _userManager;

        public AuthenticationController(UserManager<User> userManager, IMapper mapper, ILoggerManager logger)
        {
            _mapper = mapper;
            _userManager = userManager;
            _logger = logger;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserForCreationDto userForCreation)
        {
            var user = _mapper.Map<User>(userForCreation);

            var result = await _userManager.CreateAsync(user, userForCreation.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            await _userManager.AddToRolesAsync(user, userForCreation.Roles);

            return StatusCode(201);
        }

    }
}

