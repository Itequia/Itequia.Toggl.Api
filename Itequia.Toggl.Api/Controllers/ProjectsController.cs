using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Itequia.Toggl.Api.Services;
using Itequia.Toggl.Api.Services.Interfaces;
using AutoMapper;
using Itequia.Toggl.Api.Data.Models;
using Itequia.Toggl.Api.Data.DTO;
using Microsoft.AspNetCore.Authorization;
using AspNet.Security.OAuth.Validation;

namespace Itequia.Toggl.Api.Controllers
{
    [Produces("application/json")]
    [Route("/api/projects")]
    [Authorize(AuthenticationSchemes = OAuthValidationDefaults.AuthenticationScheme)]

    public class ProjectsController : Controller
    {
        private readonly IProjectsService _service;

        
        public ProjectsController(IProjectsService service)
        {
            _service = service;
        }

        
        [HttpGet]
        public IActionResult Get()
        {

            return new OkObjectResult(Mapper.Map<List<Project>, List<ProjectDTO>>(_service.Get()));
        }
    }
}