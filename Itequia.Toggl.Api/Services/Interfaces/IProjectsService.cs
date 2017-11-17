using Itequia.Toggl.Api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itequia.Toggl.Api.Services.Interfaces
{
    public interface IProjectsService
    {
        List<Project> Get();        
    }
}
