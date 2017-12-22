using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Itequia.Toggl.Api.Services;
using Itequia.Toggl.Api.Services.Interfaces;
using Itequia.Toggl.Api.Data.Models;
using Itequia.Toggl.Api.Data.DTO;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;
using AspNet.Security.OAuth.Validation;
using Microsoft.AspNetCore.Identity;

namespace Itequia.Toggl.Api.Controllers
{
    [Produces("application/json")]
    [Route("/api/records")]
    [Authorize(AuthenticationSchemes = OAuthValidationDefaults.AuthenticationScheme)]
    public class RecordsController : Controller
    {
        private readonly IRecordsService _service;
        private readonly UserManager<ApplicationUser> _userManager;

        public RecordsController(IRecordsService service, UserManager<ApplicationUser> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        [HttpGet]
        public async Task<IActionResult> Get(string description = null, DateTime? end = null, DateTime? start = null, string projectName = null, string sort = null)
        {
            var user = await GetCurrentUserAsync();
            return new OkObjectResult(Mapper.Map<List<Record>, List<RecordDTO>>(_service.Get(user.Id, description, end, start, projectName, sort)));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var user = await GetCurrentUserAsync();
                return new OkObjectResult(_service.Get(user.Id, id));
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RecordDTO record)
        {            
            try
            {
                var user = await GetCurrentUserAsync();
                return new OkObjectResult(Mapper.Map<Record, RecordDTO>(_service.Post(user.Id, Mapper.Map<RecordDTO, Record>(record))));
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }

        [Route("{id}")]
        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody]RecordDTO record)
        {
            try
            {
                var user = await GetCurrentUserAsync();
                _service.Put(user.Id, id, Mapper.Map<RecordDTO, Record>(record));
                return new OkResult();
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }            
        }

        [HttpPatch]
        [Route("{id}")]
        public async Task<IActionResult> Patch(int id, [FromBody]RecordDTO record)
        {
            try
            {
                var user = await GetCurrentUserAsync();
                _service.Patch(user.Id, id, Mapper.Map<RecordDTO, Record>(record));
                return new OkResult();
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var user = await GetCurrentUserAsync();
                _service.Delete(user.Id, id);
                return new OkResult();
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}