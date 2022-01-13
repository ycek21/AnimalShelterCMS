using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace RestApi.Controllers
{
    [Route("api/configs")]
    [ApiController]
    [Authorize]
    public class ConfigController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repository;
        private readonly IAuthenticationManager _authManager;


        public ConfigController(IMapper mapper, ILoggerManager logger, IRepositoryManager repository, IAuthenticationManager authManager)
        {
            _mapper = mapper;
            _logger = logger;
            _repository = repository;
            _authManager = authManager;
        }

        [HttpGet, Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetAllConfigs()
        {
            var configEntities = await _repository.Config.GetAllConfigs(false);

            var configDtos = _mapper.Map<List<ConfigDto>>(configEntities);

            return Ok(configDtos);
        }

        [HttpPatch("{configId}"), Authorize(Roles = "Administrator")]
        public async Task<IActionResult> PatchConfig(string configId, [FromBody] ConfigForPatchDto configForPatch)
        {
            var configEntity = await _repository.Config.GetConfigById(configId, false);

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

            configEntity.Value = configForPatch.Value;
            configEntity.ModifiedBy = userId;
            configEntity.ModifiedAt = DateTime.Now;

            _repository.Config.Update(configEntity);

            await _repository.SaveAsync();

            return NoContent();

        }

    }
}