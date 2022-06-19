using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using EmailService;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly UserManager<User> _userManager;
        private readonly IAuthenticationManager _authManager;

        private readonly IEmailSender _emailSender;


        public AuthenticationController(UserManager<User> userManager, IMapper mapper, ILoggerManager logger, IAuthenticationManager authManager, IEmailSender emailSender)
        {
            _mapper = mapper;
            _userManager = userManager;
            _logger = logger;
            _authManager = authManager;
            _emailSender = emailSender;
        }

        [HttpPost("register"), AllowAnonymous]
        public async Task<IActionResult> RegisterUser([FromBody] UserForCreationDto userForCreation)
        {
            if (userForCreation.Roles.Count != 1)
            {
                return StatusCode(422);
            }

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

            var confirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            var confirmationLink = Url.Action(nameof(ConfirmEmail), "Authentication", new { confirmationToken, email = user.Email }, Request.Scheme);

            var message = new Message(new string[] { user.Email }, "Account confirmation email link", confirmationLink);

            await _emailSender.SendEmailAsync(message);


            await _userManager.AddToRolesAsync(user, userForCreation.Roles);

            return StatusCode(201);
        }

        [HttpPost("login"), AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user)
        {
            if (!await _authManager.ValidateUser(user))
            {
                _logger.LogWarn($"{nameof(Authenticate)}: Authentication failed. Wrong user name or password.");
                return Unauthorized("Authentication failed. Wrong user name or password.");
            }

            if (!await _authManager.IsEmailConfirmed(user.Email))
            {
                return Unauthorized(new { error = "Email not confirmed." });
            }
            return Ok(new { Token = await _authManager.CreateToken() });
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string confirmationToken, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return BadRequest("User with such e-mail doesn't exist.");
            }

            var result = await _userManager.ConfirmEmailAsync(user, confirmationToken);
            var url = "http://localhost:4200/home";

            return Redirect(url);
        }
    }


}


