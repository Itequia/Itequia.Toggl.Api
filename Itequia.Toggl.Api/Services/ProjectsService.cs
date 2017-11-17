using Itequia.Toggl.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itequia.Toggl.Api.Data.Models;
using Itequia.Toggl.Api.Data.Repositories.Interfaces;

namespace Itequia.Toggl.Api.Services
{
    public class ProjectsService : IProjectsService
    {
        private readonly IBaseRepository<Project> _baseRepository;

        public ProjectsService(IBaseRepository<Project> repository)
        {
            _baseRepository = repository;
        }

        public List<Project> Get()
        {
            return _baseRepository.GetAll().ToList();
        }       
    }
}

